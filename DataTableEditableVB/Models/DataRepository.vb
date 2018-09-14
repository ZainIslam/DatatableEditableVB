Public Class DataRepository
    Public Shared CompanyData As IList(Of Company) = Nothing

    Public Shared Function GetCompanies() As IList(Of Company)
        If CompanyData Is Nothing Then
            CompanyData = New List(Of Company)()
            CompanyData.Add(New Company() With {
                .Name = "Emkay Entertainments",
                .Address = "Nobel House, Regent Centre",
                .Town = "Lothian"
            })
            CompanyData.Add(New Company() With {
                .Name = "The Empire",
                .Address = "Milton Keynes Leisure Plaza",
                .Town = "Buckinghamshire"
            })
            CompanyData.Add(New Company() With {
                .Name = "Asadul Ltd",
                .Address = "Hophouse",
                .Town = "Essex"
            })
            CompanyData.Add(New Company() With {
                .Name = "Gargamel",
                .Address = "",
                .Town = ""
            })
            CompanyData.Add(New Company() With {
                .Name = "Ashley Mark Publishing Company",
                .Address = "1-2 Vance Court",
                .Town = "Tyne & Wear"
            })
            CompanyData.Add(New Company() With {
                .Name = "MuchMoreMusic Studios",
                .Address = "Unit 29",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Victoria Music Ltd",
                .Address = "Unit 215",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Abacus Agent",
                .Address = "Regent Street",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Atomic",
                .Address = "133 Longacre",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Pyramid Posters",
                .Address = "The Works",
                .Town = "Leicester"
            })
            CompanyData.Add(New Company() With {
                .Name = "Kingston Smith Financial Services Ltd",
                .Address = "105 St Peter's Street",
                .Town = "Herts"
            })
            CompanyData.Add(New Company() With {
                .Name = "Garrett Axford PR",
                .Address = "Harbour House",
                .Town = "West Sussex"
            })
            CompanyData.Add(New Company() With {
                .Name = "Derek Boulton Management",
                .Address = "76 Carlisle Mansions",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Total Concept Management (TCM)",
                .Address = "PO Box 128",
                .Town = "West Yorks"
            })
            CompanyData.Add(New Company() With {
                .Name = "Billy Russell Management",
                .Address = "Binny Estate",
                .Town = "Edinburgh"
            })
            CompanyData.Add(New Company() With {
                .Name = "Stage Audio Services",
                .Address = "Unit 2",
                .Town = "Stourbridge"
            })
            CompanyData.Add(New Company() With {
                .Name = "Windsong International",
                .Address = "Heather Court",
                .Town = "Kent"
            })
            CompanyData.Add(New Company() With {
                .Name = "Vivante Music Ltd",
                .Address = "32 The Netherlands",
                .Town = "Surrey"
            })
            CompanyData.Add(New Company() With {
                .Name = "Way to Blue",
                .Address = "First Floor",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Glasgow City Halls",
                .Address = "32 Albion Street",
                .Town = "Lanarkshire"
            })
            CompanyData.Add(New Company() With {
                .Name = "The List",
                .Address = "14 High St",
                .Town = "Edinburgh"
            })
            CompanyData.Add(New Company() With {
                .Name = "Wilkinson Turner King",
                .Address = "10A London Road",
                .Town = "Cheshire"
            })
            CompanyData.Add(New Company() With {
                .Name = "GSC Solicitors",
                .Address = "31-32 Ely Place",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Vanessa Music Co",
                .Address = "35 Tower Way",
                .Town = "Devon"
            })
            CompanyData.Add(New Company() With {
                .Name = "Regent Records",
                .Address = "PO Box 528",
                .Town = "West Midlands"
            })
            CompanyData.Add(New Company() With {
                .Name = "BBC Radio Lancashire",
                .Address = "20-26 Darwen St",
                .Town = "Blackburn"
            })
            CompanyData.Add(New Company() With {
                .Name = "The Citadel Arts Centre",
                .Address = "Waterloo Street",
                .Town = "Merseyside"
            })
            CompanyData.Add(New Company() With {
                .Name = "Villa Audio Ltd",
                .Address = "Baileys Yard",
                .Town = "Essex"
            })
            CompanyData.Add(New Company() With {
                .Name = "cave 3",
                .Address = "",
                .Town = ""
            })
            CompanyData.Add(New Company() With {
                .Name = "Idle Eyes Printshop",
                .Address = "81 Sheen Court",
                .Town = "Surrey"
            })
            CompanyData.Add(New Company() With {
                .Name = "Miggins Music (UK)",
                .Address = "33 Mandarin Place",
                .Town = "Oxon"
            })
            CompanyData.Add(New Company() With {
                .Name = "Magic 999",
                .Address = "St Paul's Square",
                .Town = "Lancashire"
            })
            CompanyData.Add(New Company() With {
                .Name = "Delga Group",
                .Address = "Seaplane House, Riverside Est.",
                .Town = "Kent"
            })
            CompanyData.Add(New Company() With {
                .Name = "Zane Music",
                .Address = "162 Castle Hill",
                .Town = "Berkshire"
            })
            CompanyData.Add(New Company() With {
                .Name = "Universal Music Operations",
                .Address = "Chippenham Drive",
                .Town = "Milton Keynes"
            })
            CompanyData.Add(New Company() With {
                .Name = "Gotham Records",
                .Address = "PO Box 6003",
                .Town = "Birmingham"
            })
            CompanyData.Add(New Company() With {
                .Name = "Timbuktu Music Ltd",
                .Address = "99C Talbot Road",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Online Music",
                .Address = "Unit 18, Croydon House",
                .Town = "Surrey"
            })
            CompanyData.Add(New Company() With {
                .Name = "Irish Music Magazine",
                .Address = "11 Clare St",
                .Town = "Ireland"
            })
            CompanyData.Add(New Company() With {
                .Name = "Savoy Records",
                .Address = "PO Box 271",
                .Town = "Surrey"
            })
            CompanyData.Add(New Company() With {
                .Name = "Temple Studios",
                .Address = "97A Kenilworth Road",
                .Town = "Middlesex"
            })
            CompanyData.Add(New Company() With {
                .Name = "Gravity Shack Studio",
                .Address = "Unit 3 ",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Dovehouse Records",
                .Address = "Crabtree Cottage",
                .Town = "Oxon"
            })
            CompanyData.Add(New Company() With {
                .Name = "Citysounds Ltd",
                .Address = "5 Kirby Street",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Revolver Music Publishing",
                .Address = "152 Goldthorn Hill",
                .Town = "West Midlands"
            })
            CompanyData.Add(New Company() With {
                .Name = "Jug Of Ale",
                .Address = "43 Alcester Road",
                .Town = "West Midlands"
            })
            CompanyData.Add(New Company() With {
                .Name = "Isles FM 103",
                .Address = "PO Box 333",
                .Town = "Western Isles"
            })
            CompanyData.Add(New Company() With {
                .Name = "Headscope",
                .Address = "Headrest",
                .Town = "East Sussex"
            })
            CompanyData.Add(New Company() With {
                .Name = "Universal Music Ireland",
                .Address = "9 Whitefriars",
                .Town = "Ireland"
            })
            CompanyData.Add(New Company() With {
                .Name = "Zander Exports",
                .Address = "34 Sapcote Trading Centre",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Midem (UK)",
                .Address = "Walmar House",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "La Rocka Studios",
                .Address = "Post Mark House",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Warner Home DVD",
                .Address = "Warner House",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Music Room",
                .Address = "The Old Library",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Blue Planet",
                .Address = "96 York Street",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Dream 107.7FM",
                .Address = "Cater House",
                .Town = "Chelmsford"
            })
            CompanyData.Add(New Company() With {
                .Name = "Moneypenny Agency",
                .Address = "The Stables, Westwood House",
                .Town = "East Yorks"
            })
            CompanyData.Add(New Company() With {
                .Name = "Artsun",
                .Address = "18 Sparkle Street",
                .Town = "Manchester"
            })
            CompanyData.Add(New Company() With {
                .Name = "Clyde 2",
                .Address = "Clydebank Business Park",
                .Town = "Glasgow"
            })
            CompanyData.Add(New Company() With {
                .Name = "9PR",
                .Address = "65-69 White Lion Street",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "River Studio's",
                .Address = "3 Grange Yard",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Start Entertainments Ltd",
                .Address = "3 Warmair House",
                .Town = "Middx"
            })
            CompanyData.Add(New Company() With {
                .Name = "Vinyl Tap Mail Order Music",
                .Address = "1 Minerva Works",
                .Town = "West Yorkshire"
            })
            CompanyData.Add(New Company() With {
                .Name = "Passion Music",
                .Address = "20 Blyth  Rd",
                .Town = "Middlesex"
            })
            CompanyData.Add(New Company() With {
                .Name = "SuperVision Management",
                .Address = "Zeppelin Building",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Lite FM",
                .Address = "2nd Floor",
                .Town = "Peterborough"
            })
            CompanyData.Add(New Company() With {
                .Name = "ISIS Duplicating Company",
                .Address = "Sales & Production",
                .Town = "Merseyside"
            })
            CompanyData.Add(New Company() With {
                .Name = "Vanderbeek & Imrie Ltd",
                .Address = "15 Marvig",
                .Town = "Scotland"
            })
            CompanyData.Add(New Company() With {
                .Name = "Glamorgan University",
                .Address = "Student Union",
                .Town = "Mid Glamorgan"
            })
            CompanyData.Add(New Company() With {
                .Name = "Web User",
                .Address = "IPC Media",
                .Town = "London "
            })
            CompanyData.Add(New Company() With {
                .Name = "Farnborough Recreation Centre",
                .Address = "1 Westmead",
                .Town = "Hampshire"
            })
            CompanyData.Add(New Company() With {
                .Name = "Robert Owens/Musical Directions",
                .Address = "352A Kilburn Lane",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Magick Eye Records",
                .Address = "PO Box 3037",
                .Town = "Berks"
            })
            CompanyData.Add(New Company() With {
                .Name = "Alexandra Theatre",
                .Address = "Station Street",
                .Town = "West Midlands"
            })
            CompanyData.Add(New Company() With {
                .Name = "Keda Records",
                .Address = "The Sight And Sound Centre",
                .Town = "Middlesex"
            })
            CompanyData.Add(New Company() With {
                .Name = "Independiente Ltd",
                .Address = "The Drill Hall",
                .Town = "London"
            })
            CompanyData.Add(New Company() With {
                .Name = "Shurwood Management",
                .Address = "Tote Hill Cottage",
                .Town = "West Sussex"
            })
            CompanyData.Add(New Company() With {
                .Name = "Fury Records",
                .Address = "PO Box 52",
                .Town = "Kent"
            })
            CompanyData.Add(New Company() With {
                .Name = "Northumbria University",
                .Address = "Union Building",
                .Town = "Newcastle upon Tyne"
            })
   
        End If

        Return CompanyData
    End Function
End Class
