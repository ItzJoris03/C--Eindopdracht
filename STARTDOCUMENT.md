# Eindopdracht C#
**Eindopdracht C# - Opdracht 6: Containerverhuur** 
**Door:** *Joris Hummel*
**Datum:** *02-06-2022*

## Probleemdefinitie

De containerverhuurbedrijf wil een programma waarmee voor iedere container het volume van de bak, evenals de begin- en einddatum van de huurperiode kunnen worden ingevoerd. Voor iedere verhuurde container moeten de verschuldigde kosten worden berekend en getoond. Daarnaast moeten cumulatief de totale inkomsten, het gemiddelde volume en de langste huurperiode worden getoond.


### Invoer
|Case|Type|Voorwaarde|
|--|--|--|
|Container Nummer|`int`|`getal` > 0|
|Container Volume|`float`| `getal` > 0|
|Rent Start Date|`string`|formaat *"ddmmjjjj"*|
|Rent End Date|`string`|formaat *"ddmmjjjj"*|


### Uitvoer
|Case|Type|
|--|--|
|Huurkosten|`float`|
|Totale inkomsten|`float`|
|Gemiddelde Volume|`float`|
|Langste huurperiode|`string`|

### Berekeningen
|Case|Berekeningen|
|--|--|
|Huurkosten|aantal dagen * 40 * m3 + afvoerkosten|
|Totale inkomsten|Som van de totale rekeningen|
|Gemiddelde Volume|Som van alle volumes van ieder container / aantal containers|

### Constanten
de huur bedraagt € 40,- per m3 per dag.

### Bepalingen
Het afvoeren van een bak kost € 60,- als het volume van de bak 2 m3 of minder  
bedraagt, anders € 125,-.  


## GUI

![About Box](./img/About%20Box.png)
![Container Info](./img/Container%20Info.png)
![Containers Overzicht](./img/Containers.png)
![General](./img/General.png)


## UML-Diagram

![](https://mermaid.ink/img/pako:eNqVVMFu3CAQ_RWEevB216v0iqpKSbaHShspSqKefCFm1kHFUAG2VCWbb--sjW3ssFHigwXMm5n3ZgaeaWkEUEZLxZ3bSV5ZXhea4CekhdJLo8n-rj_pMOTaaM-lBnsHuFDPve305eVgcozspfOvI_Z1Qq0XAbJVZLN4lI2AFWmNFJG5Av9g0OfWmoP02YoclOF-Dgi2KEgCtDe6Aud7BrdgpREYzXkrdTVH_jaqqeGyBcsrSGTkQoypss74hrWF2rQwoZL6jskak7i8UjAidZQ8bztybEkql-6y5VLxR4XGR2NUbNOYtIShRb_6bbJB2Sz-KtGIa-O8m1clCIlLS7bblx8kZCIMV0947mPFM3gkuuSqbBT3EDJ9WWo9GFtz_yBryPr2ISTuY6AzJC_oxXb7taDke57j5huuRrkxnwH_fv2d59bvkB0jAv-RBbRIna9D3Czy7NluyOgSdCzGOjWkQdw0LqjorLy-xOmrvLu6uY-1rksLXdGHSRivNpu8sNLz2cJJ59Nt6Lp1_hmYYbNQW_RYtKPDClDweTa9hqHiH1cQPCb-iTsS4Qbu5IWcyRGAbwR9OMBE8kg3tAYceSnw1e46VlD_BDUUlOFScPunoIU-4Zq_p-H7KaQ3lrIDVw42lDfe3P_TJWXeNjCAwssfUMf_CoLvwg)

**RentalPeriod** is een abstracte klasse. De methodes in deze klasse zijn standaard methodes die de container klasse moet hebben, maar niet tot de klasse zelf behoort. Er kan met een abstracte klasse geen object gemaakt worden en biedt een stukje veiligheid in de code.

**Container** bevat een id, volume en een isAvailable velden. Deze velden komen rechtstreeks vanuit de database, zodat ze ergens opgeslagen kunnen worden in objecten zonder ze rechtstreeks vanuit de database op het scherm te plakken. Het is ook mogelijk om de totale winsten per container uit te kunnen rekenen aan de hand van de facturen uit de database.

**Invoice** bevat een id, start- en einddatum en erft de abstracte klasse **RentalPeriod** over en maakt deze gebruik van de methodes in de abstracte klasse.
Dit biedt de mogelijkheid om data te valideren en te bewerken naar gewenste formaat.

**ContainerRental** is in feite het bedrijf zelf. Deze slaat alle containers op in een lijst, om ze te kunnen valideren, uitprinten, bewerken, etc. Met deze klasse kan ook een container worden verhuurd, totale winsten uitberekend worden van alle containers bij elkaar, evenals de langste huur periode, gemiddelde container volume etc.

**ContainerRDBMS** is een klasse die alle database queries afhandelt. Dit om overzicht in de code te bewaren. Het is een volledig statische klasse.

De klasse **ContainerRental** is niet statisch, omdat er meerdere containerverhuurbedrijven kunnen zijn, daarom worden er hier wel objecten van gemaakt.

## ERD

![](https://mermaid.ink/img/pako:eNp9kMEKwjAMhl8l5OxeYDdxCuJF8LpLtkYtdo102UDm3t1WpxMPpoeW7_9J0n_AWgxjjhwKS6dATekh1kq8kvUc4H7PMhlg63uxNUMOJcbzYxpeIJX1ClsD-92Mjk5IoRfXNTzTSsSBbZc9WUeVm5QRXvd73v_OCX22iNrmSzOkDK1S0CK-fjh7M9NxFlPhAhsODVkTc3nOL1HPHHfH9HtD4ZISGKOvu6Zua2NVAuZHci0vkDqVw83XmGvo-G2a4p1c4wPCeHIY)

# Testgegevens


## GUI
De tabbladen werken zoals behoren:
- **General:** *gaat naar de hoofdpagina.*
- **Containers:** *gaat naar de container overzichtspagina, waar alle containers zichtbaar op een rij staan.*
- **Zoekbalk:** *als daar een containernaam ingevuld wordt, gaat deze naar de desbetreffende overzichtspagina van de container.*


De goud-gele knop moet volgens verwachtingen werken:
- De okay knop in de **'about-box'** wijst naar de **'General'** tabblad.
- De okay knop in de individuele container tabblad wijst naar de container overzichtspagina.


Als er bij de container overzichtspagina op het labeltje **'Container Id'**, **'Total Volume'** of **'Available'** wordt gedrukt, filtert de lijst op containers op volgorde van de label:
- **'Container Id':** *zorgt voor volgorde van de container Id benaming.*
- **'Total Volume':** *zorgt voor de volgorde van de totale volume.*
- **'Available':** *zorgt voor de volgorde van beschikbare containers*

## Start Data
### Database
**Container**
|Id|Volume|isAvailable|
|--|--|--|
|`1`|`2,0`|`true`|
|`2`|`18,21`|`true`|
|`3`|`37,57`|`false`|
|`4`|`15,641`|`false`|
|`5`|`1,4`|`false`|
|`6`|`135,0`|`true`|
|`7`|`46,8`|`true`|
|`8`|`23,1`|`true`|
|`9`|`12,45`|`false`|
|`10`|`0,86`|`true`|
|`11`|`34,13`|`true`|
|`12`|`75,4`|`false`|

**Invoice**
|Id|ContainerId|startDate|endDate|
|--|--|--|--|
|`1`|`6`|`2016-01-31`|`2016-02-27`|
|`2`|`1`|`2014-05-21`|`2014-06-19`|
|`3`|`5`|`2018-11-13`|`2019-02-05`|
|`4`|`12`|`2015-10-07`|`2016-05-09`|
|`5`|`4`|`2020-02-18`|`2020-07-11`|
|`6`|`8`|`2019-06-28`|`2019-11-20`|
|`7`|`4`|`2021-03-24`|`2021-10-28`|
|`8`|`9`|`2015-01-06`|`2015-08-31`|
|`9`|`10`|`2016-09-30`|`2017-05-19`|
|`10`|`6`|`2017-08-23`|`2017-09-05`|
|`11`|`3`|`2019-03-19`|`2019-06-14`|
|`12`|`8`|`2016-12-01`|`2017-01-20`|

### Classes

**ContainerRental**
| Id | Input | Code |
|--|--|--|
| Company | | `new ContainerRental()`|

## Test Cases
**Ophalen van containers**

Als er op het tabblad *Containers* gedrukt wordt, worden alle containers opgehaald uit de database in de `containers: List<Container>` uit de `ContainerRental` klasse. 

**Informatie per container**

Als er op een container gedrukt wordt in de *Containers* tabblad, dan worden alle informatie over de container opgehaald uit de database.


|Invoer|||Uitvoer|||
|Container| Begindag|Einddag|Kosten|Totale inkomsten|Langste period|
|--|--|--|--|--|--|
|`2m3`|`01-01-2022`|`05-01-2022`|`380`|`380`|`4 dagen`|
|`18m3`|`02-01-2022`|`06-01-2022`|`3005`|`3385`|`4 dagen`|
|`37m3`|`01-01-2022`|`10-01-2022`|`13445`|`16830`|`9 dagen`|
|``|``|``|``|``|``|

