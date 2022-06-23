using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerVerhuurBedrijf
{
    internal static class ContainerRDBMS
    {
        private static SqlConnection getConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\joris\Documents\NHL Stenden Hogeschool\Leerjaar 1\Periode 4\C#\Eindopdracht\C--Eindopdracht\ContainerVerhuurBedrijf\ContainerVerhuurBedrijf\ContainerDatabase.mdf';Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        private static void closeConnection(SqlConnection conn, SqlCommand cmd, SqlDataReader reader = null)
        {
            conn.Close();
            cmd.Dispose();

            if(reader != null)
            {
                reader.Close();
            }
        }

        public static bool createContainer(Container container)
        {
            SqlConnection conn = getConnection();

            string sql = "INSERT INTO Container(Volume) VALUES (@volume); SELECT Id, IsAvailable FROM Container WHERE Id = SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.Parameters.AddWithValue("@volume", container.volume);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    container.id = (int)reader.GetValue(0);
                    container.isAvailable = (bool)reader.GetValue(1);
                }
                closeConnection(conn, cmd);
                return true;
            } 
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                closeConnection(conn, cmd);
                return false;
            }
        }

        public static List<Container> readContainers()
        {
            List<Container> containers = new List<Container>();
            SqlConnection conn = getConnection();

            string sql = "SELECT Id, Volume, IsAvailable FROM Container";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                try
                {
                    int id = (int)reader.GetValue(0);
                    double volume = (double)reader.GetValue(1);
                    bool isAvailable = (bool)reader.GetValue(2);

                    containers.Add(new Container(id, ((float)volume), isAvailable));
                }
                catch(InvalidCastException e)
                {
                    string msg = e.Message;
                }
            }

            closeConnection(conn, cmd, reader);

            return containers;
        }

        public static Container readContainer(int id)
        {
            Container container = null;
            SqlConnection conn = getConnection();

            string sql = "SELECT Id, Volume, IsAvailable FROM Container WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    id = (int)reader.GetValue(0);
                    double volume = (double)reader.GetValue(1);
                    bool isAvailable = (bool)reader.GetValue(2);
                    container = new Container(id, ((float)volume), isAvailable);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            closeConnection(conn, cmd, reader);

            return container;
        }

        public static bool deleteContainer(Container container)
        {
            SqlConnection conn = getConnection();

            string sql = "DELETE FROM Container WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", container.id);

            try
            {
                cmd.ExecuteNonQuery();
                closeConnection(conn, cmd);
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                closeConnection(conn, cmd);
                return false;
            }
        }

        public static bool createPeriod(Period period)
        {
            SqlConnection conn = getConnection();

            string sql = "INSERT INTO Period VALUES(@containerId, @startDate, @endDate)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@containerId", period.containerId);

            cmd.Parameters.AddWithValue("@startDate", period.startDate);
            cmd.Parameters.AddWithValue("@endDate", period.endDate);

            try
            {
                cmd.ExecuteNonQuery();
                closeConnection(conn, cmd);
                return true;
            } 
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public static List<Period> readPeriods(Container container)
        {
            List<Period> periods = new List<Period>();
            SqlConnection conn = getConnection();

            string sql = "SELECT Id, StartDate, EndDate FROM Period WHERE ContainerId = @containerId";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@containerId", container.id);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    int id = (int)reader.GetValue(0);
                    int containerId = container.id;
                    DateTime startDate = (DateTime)reader.GetValue(1);
                    DateTime endDate = (DateTime)reader.GetValue(2);
                    periods.Add(new Period(id, containerId, startDate, endDate));
                }
                catch (InvalidCastException e)
                {
                    string msg = e.Message;
                }
            }

            closeConnection(conn, cmd, reader);

            return periods;
        }
    }
}
