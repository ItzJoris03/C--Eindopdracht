using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVerhuurBedrijf
{
    public partial class AppViewer : Form
    {
        ContainerRental company;

        public AppViewer()
        {
            InitializeComponent();

            this.company = new ContainerRental();

            update();
        }

        public void update(int index = 0)
        {
            List<TabPage> tabPages = new List<TabPage>() {
                this.tabPage_General,
                this.tabPage_Containers,
                this.tabPage_CheckInputs
            };

            this.tableOverviewPanel.Controls.Clear();

            Button button = new Button();
            button.Text = "Refresh";
            button.Name = "buttonRefresh";
            button.Click += new EventHandler(button_Refresh_Click);

            this.tableOverviewPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.tableOverviewPanel.Controls.Add(this.label_Container, 0, 0);
            this.tableOverviewPanel.Controls.Add(this.label_Volume, 1, 0);
            this.tableOverviewPanel.Controls.Add(this.label_Availability, 2, 0);
            this.tableOverviewPanel.Controls.Add(button, 3, 0);

            this.label_TotalProfits_Output.Text = "$" + Convert.ToString(company.getTotalProfits());
            this.label_AverageVolume_Output.Text = company.getVolumeAverage().ToString() + " m3";
            this.label_LongestRentalPeriod_Output.Text = company.getLongestRentalPeriod();

            this.tableOverviewPanel.RowCount = 1;

            foreach (Container container in company.containers)
            {
                string volume = container.volume.ToString() + " m3";
                string isAvailable = (container.isAvailable) ? "YES" : "NO";

                Label containerOverview = new Label();
                containerOverview.Text = container.id.ToString();

                Label volumeOverview = new Label();
                volumeOverview.Text = volume;

                Label availableOverview = new Label();
                availableOverview.Text = isAvailable;

                button = new Button();
                button.Text = "Remove";
                button.Name = container.id.ToString();
                button.Click += new EventHandler(button_Remove_Click);

                this.tableOverviewPanel.RowCount += 1;
                int row = this.tableOverviewPanel.RowCount;

                this.tableOverviewPanel.Controls.Add(containerOverview, 0, row - 1);
                this.tableOverviewPanel.Controls.Add(volumeOverview, 1, row - 1);
                this.tableOverviewPanel.Controls.Add(availableOverview, 2, row - 1);
                this.tableOverviewPanel.Controls.Add(button, 3, row - 1);
            }

            this.tabControl.SelectedTab = tabPages[index];
        }

        private void toolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void toolStripMenuItem_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                int id = Convert.ToInt32(button.Name);
                Container container = ContainerRDBMS.readContainer(id);

                if(container != null)
                {
                    if(company.removeContainer(container))
                    {
                        update(1);
                    }
                    else
                    {
                        MessageBox.Show("Couldn't remove this container");
                    }
                }
                else
                {
                    MessageBox.Show("Couldn't remove this container, because it doesn't exists");
                }
            }
            
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = this.tabPage_General;
        }

        private void containersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = this.tabPage_Containers;
        }

        private void addContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = this.tabPage_CheckInputs;
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            update(1);
        }

        private void AppViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_CalculateCosts_Click(object sender, EventArgs e)
        {
            float volume = 0f;

            if(this.textBox_CheckInputContainer.Text == "")
            {
                MessageBox.Show("Volume input can't be empty");
                return;
            }
            else
            {
                try
                {
                    volume = float.Parse(this.textBox_CheckInputContainer.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Volume has to be a valid decimal or non decimal number");
                    return;
                }

                DateTime beginDate = this.dateTimePicker_CheckInputBegin.Value;
                DateTime endDate = this.dateTimePicker_CheckInputEnd.Value;

                if(beginDate >= endDate)
                {
                    MessageBox.Show("Begin date can't be the same or greater than the end date");
                    return;
                }

                if(beginDate == endDate)
                {
                    MessageBox.Show("The begin and end date can't be the same.");
                    return;
                }

                Container container = new Container(volume);
                ContainerRDBMS.createContainer(container);
                Period period = new Period(container.id, beginDate, endDate);
                ContainerRDBMS.createPeriod(period);

                container.addPeriod(period);
                company.addContainer(container);

                this.label_CheckOutput_Costs.Text = period.calculateCosts(container).ToString();
                this.label_CheckOutput_TotalProfits.Text = company.getTotalProfits().ToString();
                this.label_CheckOutput_LongestPeriod.Text = company.getLongestRentalPeriod().ToString();

                update(2);
            }
        }
    }
}
