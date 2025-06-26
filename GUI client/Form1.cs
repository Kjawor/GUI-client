using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Text.Json;

namespace GUI_client
{

    public partial class Form1 : Form
    {

        HttpClient client;
        public Form1()
        {
            client = new HttpClient();
            InitializeComponent();
        }

        private async void Survey_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await SurveyInfo(client, textBox1);
        }






        static async Task SurveyInfo(HttpClient client, TextBox box)
        {
            await using Stream stream =
                        await client.GetStreamAsync("https://cloudserverc3631597.azurewebsites.net/api/Train/survey");



            var surveys = await JsonSerializer.DeserializeAsync<List<Survey>>(stream);



            foreach (var info in surveys)
            {

                box.AppendText($"Station: {string.Join(", ", info.Station)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Railway: {string.Join(", ", info.Railway)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Date: {info.Date}");
                box.AppendText(Environment.NewLine);
                box.AppendText("Passenger Survey Data:");
                box.AppendText(Environment.NewLine);
                foreach (var item in info.PassengerSurveyObject)
                {
                    box.AppendText($"  Year: {item.SurveyYear}, Passengers: {item.PassengerJourneys}");
                    box.AppendText(Environment.NewLine);
                }
                box.AppendText("-------------------");
                box.AppendText(Environment.NewLine);

            }
        }

        static async Task RailwayDirectionInfo(HttpClient client, TextBox box)
        {
            await using Stream stream =
                await client.GetStreamAsync("https://cloudserverc3631597.azurewebsites.net/api/Train/raildirection");
            var RailwayDirections = await JsonSerializer.DeserializeAsync<List<RailwayDirection>>(stream);

            foreach (var info in RailwayDirections)
            {
                box.AppendText($"Context: {string.Join(", ", info.Context)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Id: {string.Join(", ", info.Id)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Type: {string.Join(", ", info.Type)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Date: {string.Join(", ", info.Date)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"SameAs: {string.Join(", ", info.SameAs)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Title: {string.Join(", ", info.Title)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"English Title: {string.Join(", ", info.RailDirectionTitle.En)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Japanese Title: {string.Join(", ", info.RailDirectionTitle.Ja)}");
                box.AppendText(Environment.NewLine);
                box.AppendText("-------------------");
                box.AppendText(Environment.NewLine);

            }


        }

        static async Task RailwayInfo(HttpClient client, TextBox box)
        {
            await using Stream stream =
                await client.GetStreamAsync("https://cloudserverc3631597.azurewebsites.net/api/Train/railway");
            var Railway = await JsonSerializer.DeserializeAsync<List<Railway>>(stream);

            foreach (var info in Railway)
            {
                box.AppendText($"Context: {string.Join(", ", info.Context)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Id: {string.Join(", ", info.Id)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Type: {string.Join(", ", info.Type)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Date: {string.Join(", ", info.Date)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"SameAs: {string.Join(", ", info.SameAs)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Title: {string.Join(", ", info.Title)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"English Title: {string.Join(", ", info.RailwayTitle.En)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Japanese Title: {string.Join(", ", info.RailwayTitle.Ja)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Operator: {string.Join(", ", info.Operator)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Ascending Rail Direction: {string.Join(", ", info.AscendingRailDirection ?? "N/A")}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Descending Rail Direction: {string.Join(", ", info.DescendingRailDirection ?? "N/A")}");
                box.AppendText(Environment.NewLine);
                foreach (var item in info.StationOrder)
                {
                    box.AppendText($"Index: {string.Join(", ", item.Index)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Station: {string.Join(", ", item.Station)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"English Station Title: {string.Join(", ", item.StationTitle.En)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Japanese Station Title: {string.Join(", ", item.StationTitle.Ja)}");
                    box.AppendText(Environment.NewLine);
                }
                box.AppendText("-------------------");
                box.AppendText(Environment.NewLine);
            }
        }

        static async Task RailwayFareInfo(HttpClient client, TextBox box)
        {
            await using Stream stream =
                await client.GetStreamAsync("https://cloudserverc3631597.azurewebsites.net/api/Train/railwayfare");
            var RailwayFare = await JsonSerializer.DeserializeAsync<List<RailwayFare>>(stream);

            foreach (var info in RailwayFare)
            {

                box.AppendText($"Context: {string.Join(", ", info.Context)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Id: {string.Join(", ", info.Id)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Type: {string.Join(", ", info.Type)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Date: {string.Join(", ", info.Date)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"SameAs: {string.Join(", ", info.SameAs)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Operator: {string.Join(", ", info.Operator)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"From Station: {string.Join(", ", info.FromStation)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"To Station: {string.Join(", ", info.ToStation)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Ticket Fare: {string.Join(", ", info.TicketFare)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"IC Card Fare: {string.Join(", ", info.IcCardFare)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Child Ticket Fare: {string.Join(", ", info.ChildTicketFare)}");
                box.AppendText(Environment.NewLine);
                box.AppendText("-------------------");
                box.AppendText(Environment.NewLine);

            }

        }

        static async Task StationInfo(HttpClient client, TextBox box, TextBox boxWrite)
        {

            boxWrite.Text = "Would you like to search for a specific station?(Yes\\No)";

            string choice = "";


            await check();

            choice = boxWrite.Text;

            string selectedstation = "";
            boxWrite.Clear();



            string url = "https://cloudserverc3631597.azurewebsites.net/api/Train/station";

            if (choice.ToLower().Equals("no"))
            {
                url = "https://cloudserverc3631597.azurewebsites.net/api/Train/station";


            }

            else if (choice.ToLower().Equals("yes"))
            {
                boxWrite.Text = "enter the station";

                await check();

                selectedstation = boxWrite.Text;


                selectedstation = selectedstation.ToLower();
                selectedstation = char.ToUpper(selectedstation[0]) + selectedstation.Substring(1);
                url = $"https://cloudserverc3631597.azurewebsites.net/api/Train/station?StationName={selectedstation}";
            }

            else
            {
                box.Text = "please try again";
            }

            await using Stream stream =
                await client.GetStreamAsync(url);
            var Station = await JsonSerializer.DeserializeAsync<List<Station>>(stream);

            foreach (var info in Station)
            {
                box.AppendText($"Context: {string.Join(", ", info.Context)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Id: {string.Join(", ", info.Id)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Type: {string.Join(", ", info.Type)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Date: {string.Join(", ", info.Date)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"SameAs: {string.Join(", ", info.SameAs)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Title: {string.Join(", ", info.Title)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"English Title: {string.Join(", ", info.StationTitle.En)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Japanese Title: {string.Join(", ", info.StationTitle.Ja)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Operator: {string.Join(", ", info.Operator)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Railway: {string.Join(", ", info.Railway)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Lognitude: {string.Join(", ", info.Long)}"); //returning 0 on some but not all
                box.AppendText(Environment.NewLine);
                box.AppendText($"Latitude: {string.Join(", ", info.Lat)}"); //returning 0 on some but not all
                box.AppendText(Environment.NewLine);
                box.AppendText("-------------------");
                box.AppendText(Environment.NewLine);
            }

        }

        static async Task StationTimetableInfo(HttpClient client, TextBox box)
        {
            await using Stream stream =
                await client.GetStreamAsync("https://cloudserverc3631597.azurewebsites.net/api/Train/stationtimetable");
            var StationTimetable = await JsonSerializer.DeserializeAsync<List<StationTimetable>>(stream);


            foreach (var info in StationTimetable)
            {
                box.AppendText($"Context: {string.Join(", ", info.Context)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Id: {string.Join(", ", info.Id)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Type: {string.Join(", ", info.Type)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Date: {string.Join(", ", info.Date)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Issued: {string.Join(", ", info.Issued)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"SameAs: {string.Join(", ", info.SameAs)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Operator: {string.Join(", ", info.Operator)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Railway: {string.Join(", ", info.Railway)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"RailDirection: {string.Join(", ", info.RailDirection)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Calendar: {string.Join(", ", info.Calendar)}");
                box.AppendText(Environment.NewLine);

                foreach (var item in info.StationTimetableObject)
                {
                    box.AppendText($"Departure Time: {string.Join(", ", item.DepartureTime)}");
                    if (item.DestinationStation != null)
                    {
                        box.AppendText($"Destination: {string.Join(", ", item.DestinationStation)}");
                    }
                    else
                    {
                        box.AppendText("$Destination: N/A");
                    }
                    box.AppendText($"Train Type: {string.Join(", ", item.TrainType)}");
                    box.AppendText("-------------------");

                }

            }

        }


        static async Task TrainInfo(HttpClient client, TextBox box)
        {

            await using Stream stream =
                await client.GetStreamAsync("https://cloudserverc3631597.azurewebsites.net/api/Train/traininformation");
            var TrainInfo = await JsonSerializer.DeserializeAsync<List<TrainInformation>>(stream);

            await using Stream delayedstream = await client.GetStreamAsync("https://functionc3631597.azurewebsites.net/api/Traininfo");
            var DelayedTrains = await JsonSerializer.DeserializeAsync<List<DelayedTrains>>(delayedstream);

            foreach (var info in TrainInfo)
            {
                box.AppendText($"Context: {string.Join(", ", info.Context)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Id: {string.Join(", ", info.Id)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Type: {string.Join(", ", info.Type)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Date: {string.Join(", ", info.Date)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Valid: {string.Join(", ", info.Valid)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Time Of Origin: {string.Join(", ", info.TimeOfOrigin)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Operator: {string.Join(", ", info.Operator)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Railway: {string.Join(", ", info.Railway)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Japanese Train Information Text: {string.Join(", ", info.TrainInformationText.Ja)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"English Train Information Text: {string.Join(", ", info.TrainInformationText.En)}");
                box.AppendText(Environment.NewLine);
                box.AppendText("-------------------");
                box.AppendText(Environment.NewLine);
            }
            box.AppendText("The following trains are delayed: ");
            foreach (var train in DelayedTrains)
            {
                box.AppendText(train.Railway);
                box.AppendText(Environment.NewLine);
            }
        }


        static async Task TrainTimetableInfo(HttpClient client, TextBox box)
        {

            await using Stream stream =
                await client.GetStreamAsync("https://cloudserverc3631597.azurewebsites.net/api/Train/traintimetable");
            var TrainTimetableInfo = await JsonSerializer.DeserializeAsync<List<TrainTimetable>>(stream);

            foreach (var info in TrainTimetableInfo)
            {
                box.AppendText($"Context: {string.Join(", ", info.Context)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Id: {string.Join(", ", info.Id)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Type: {string.Join(", ", info.Type)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Date: {string.Join(", ", info.Date)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Issued: {string.Join(", ", info.Issued)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"SameAs: {string.Join(", ", info.SameAs)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Operator: {string.Join(", ", info.Operator)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Railway: {string.Join(", ", info.Railway)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"RailDirection: {string.Join(", ", info.RailDirection)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Calendar: {string.Join(", ", info.Calendar)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"TrainNumber: {string.Join(", ", info.TrainNumber)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Train Type: {string.Join(", ", info.TrainType)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Origin Station: {string.Join(", ", info.OriginStation)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Destination Station: {string.Join(", ", info.DestinationStation)}");
                box.AppendText(Environment.NewLine);
                foreach (var item in info.TrainTimetableObject)
                {
                    box.AppendText($"Departure Time: {string.Join(", ", item.DepartureTime)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Departure Station: {string.Join(", ", item.DepartureStation)}");
                    box.AppendText(Environment.NewLine);
                }
                box.AppendText("-------------------");
                box.AppendText(Environment.NewLine);
            }
        }


        static async Task TrainTypeinfo(HttpClient client, TextBox box)
        {
            await using Stream stream =
             await client.GetStreamAsync("https://cloudserverc3631597.azurewebsites.net/api/Train/traintype");
            var TrainTypeInfo = await JsonSerializer.DeserializeAsync<List<TrainType>>(stream);

            foreach (var info in TrainTypeInfo)
            {
                box.AppendText($"Context: {string.Join(", ", info.Context)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Id: {string.Join(", ", info.Id)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Type: {string.Join(", ", info.Type)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Date: {string.Join(", ", info.Date)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"SameAs: {string.Join(", ", info.SameAs)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Operator: {string.Join(", ", info.Operator)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Title: {string.Join(", ", info.Title)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"English Title: {string.Join(", ", info.TrainTypeTitle.En)}");
                box.AppendText(Environment.NewLine);
                box.AppendText($"Japanese Title: {string.Join(", ", info.TrainTypeTitle.Ja)}");
                box.AppendText(Environment.NewLine);
                box.AppendText("-------------------");
                box.AppendText(Environment.NewLine);
            }

        }
        static async Task StationAndTimetableInfo(HttpClient client ,TextBox boxWrite, TextBox box) {



            string selectedstation = "";
            boxWrite.Clear();





         
                boxWrite.Text = "enter the station";

                await check();

                selectedstation = boxWrite.Text;


                selectedstation = selectedstation.ToLower();
                selectedstation = char.ToUpper(selectedstation[0]) + selectedstation.Substring(1);
                


            await using Stream stream =
                await client.GetStreamAsync($"https://cloudserverc3631597.azurewebsites.net/api/Train/stationandtimetable?station={selectedstation}");
            var certaintimetable = await JsonSerializer.DeserializeAsync<List<List<StationTimetable>>>(stream);

            foreach (var firstinfo in certaintimetable)
            {
                foreach (var info in firstinfo)
                {
                    box.AppendText($"Context: {string.Join(", ", info.Context)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Id: {string.Join(", ", info.Id)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Type: {string.Join(", ", info.Type)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Date: {string.Join(", ", info.Date)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Issued: {string.Join(", ", info.Issued)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"SameAs: {string.Join(", ", info.SameAs)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Operator: {string.Join(", ", info.Operator)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Railway: {string.Join(", ", info.Railway)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"RailDirection: {string.Join(", ", info.RailDirection)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Calendar: {string.Join(", ", info.Calendar)}");
                    box.AppendText(Environment.NewLine);

                    foreach (var item in info.StationTimetableObject)
                    {
                        box.AppendText($"Departure Time: {string.Join(", ", item.DepartureTime)}");
                        box.AppendText(Environment.NewLine);
                        if (item.DestinationStation != null)
                        {
                            box.AppendText($"Destination: {string.Join(", ", item.DestinationStation)}");
                            box.AppendText(Environment.NewLine);
                        }
                        else
                        {
                            box.AppendText("$Destination: N/A");
                            box.AppendText(Environment.NewLine);
                        }
                        box.AppendText($"Train Type: {string.Join(", ", item.TrainType)}");
                        box.AppendText(Environment.NewLine);
                        box.AppendText("-------------------");
                        box.AppendText(Environment.NewLine);

                    }
                }
            }


        }

        static async Task StationAndSurveyInfo(HttpClient client, TextBox boxWrite, TextBox box) {



            string selectedstation = "";
            boxWrite.Clear();



            boxWrite.Text = "enter the station";

            await check();

            selectedstation = boxWrite.Text;


            selectedstation = selectedstation.ToLower();
            selectedstation = char.ToUpper(selectedstation[0]) + selectedstation.Substring(1);



            await using Stream stream =
                await client.GetStreamAsync($"https://cloudserverc3631597.azurewebsites.net/api/Train/stationandsurvey?station={selectedstation}");
            var certainsurvey = await JsonSerializer.DeserializeAsync<List<List<Survey>>>(stream);

            foreach (var firstinfo in certainsurvey)
            {
                foreach (var info in firstinfo)
                {
                    box.AppendText($"Station: {string.Join(", ", info.Station)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Railway: {string.Join(", ", info.Railway)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Date: {info.Date}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText("Passenger Survey Data:");
                    box.AppendText(Environment.NewLine);
                    foreach (var item in info.PassengerSurveyObject)
                    {
                        box.AppendText($"  Year: {item.SurveyYear}, Passengers: {item.PassengerJourneys}");
                        box.AppendText(Environment.NewLine);
                    }
                    box.AppendText("-------------------");
                    box.AppendText(Environment.NewLine);

                }
            }


        }

        static async Task StationAndFareInfo(HttpClient client, TextBox boxWrite, TextBox box) {



            string firstselectedstation = "";
            string secondselectedstation = "";
            boxWrite.Clear();



            boxWrite.Text = "enter the first station";

            await check();

            firstselectedstation = boxWrite.Text;

            boxWrite.Clear();

            boxWrite.Text = "enter the second station";
            await check();
            secondselectedstation = boxWrite.Text;



            firstselectedstation = firstselectedstation.ToLower();
            firstselectedstation = char.ToUpper(firstselectedstation[0]) + firstselectedstation.Substring(1);

            secondselectedstation = secondselectedstation.ToLower();
            secondselectedstation = char.ToUpper(secondselectedstation[0]) + secondselectedstation.Substring(1);



            await using Stream stream =
                await client.GetStreamAsync($"https://cloudserverc3631597.azurewebsites.net/api/Train/stationandrailwayfare?ToStation={firstselectedstation}&FromStation={secondselectedstation}");
            var certainfare = await JsonSerializer.DeserializeAsync<List<RailwayFare>>(stream);

            foreach (var info in certainfare)
            {
            
                    box.AppendText($"Context: {string.Join(", ", info.Context)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Id: {string.Join(", ", info.Id)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Type: {string.Join(", ", info.Type)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Date: {string.Join(", ", info.Date)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"SameAs: {string.Join(", ", info.SameAs)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Operator: {string.Join(", ", info.Operator)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"From Station: {string.Join(", ", info.FromStation)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"To Station: {string.Join(", ", info.ToStation)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Ticket Fare: {string.Join(", ", info.TicketFare)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"IC Card Fare: {string.Join(", ", info.IcCardFare)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText($"Child Ticket Fare: {string.Join(", ", info.ChildTicketFare)}");
                    box.AppendText(Environment.NewLine);
                    box.AppendText("-------------------");
                    box.AppendText(Environment.NewLine);

                
            }


        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private async void Station_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await StationInfo(client, textBox1, textBox2);
        }

        static TaskCompletionSource<bool> flag = new TaskCompletionSource<bool>();

        static private async Task check()
        {
            await flag.Task;
            flag = new TaskCompletionSource<bool>();

        }


        private async void send_Click(object sender, EventArgs e)
        {
             flag.SetResult(true);
        }

        private async void RailDirection_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await RailwayDirectionInfo(client, textBox1);
        }

        private async void Railway_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await RailwayInfo(client, textBox1);
        }

        private async void RailwayFare_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await RailwayFareInfo(client, textBox1);
        }

        private async void StationTimetable_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await StationTimetableInfo(client, textBox1);
        }

        private async void TrainInformation_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await TrainInfo(client, textBox1);
        }

        private async void TrainTimetable_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await TrainTimetableInfo(client, textBox1);
        }

        private async void TrainType_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await TrainTypeinfo(client, textBox1);
        }

        private async void StationAndTimetable_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await StationAndTimetableInfo(client, textBox2, textBox1);
        }

        private async void StationAndSurvey_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await StationAndSurveyInfo(client, textBox2, textBox1);
        }

        private async void StationAndRailwayFare_Click(object sender, EventArgs e)
        {
             textBox1.Clear();
            await StationAndFareInfo(client, textBox2, textBox1);
        }
    }
}
