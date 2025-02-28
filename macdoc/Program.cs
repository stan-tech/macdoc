﻿using Infobip.Api.Client;
using Infobip.Api.Client.Api;
using Infobip.Api.Client.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using System.Windows.Forms;

namespace macdoc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            if (args.Length > 0)
            {
                Home.RefSearch = true;
                Application.Run(new ApplicationStartUp());

            }
            else
            {
                Home.RefSearch = false;
                Application.Run(new Home());

            }

        }
    }
    public class ApplicationStartUp : Home
    {
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        List<Component> componentsToModifiy = new List<Component>();
        NotifyIcon MaintenanceNotif = new NotifyIcon();


        bool AppStarted = false;

        void OnTimer(object sender, ElapsedEventArgs e)
        {

        }
        void OnDoubleClick(object sender, EventArgs e)
        {
            if (!AppStarted)
            {
                Visible = true;
                ShowInTaskbar = true;
                AppStarted = true;


                if (componentsToModifiy.Count > 0)
                {
                    this.Search.Text = componentsToModifiy[0].Reference;

                }
            }
        }
        private void InitializeComponent()
        {

            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit);
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Ouvrir Macdoc";
            trayIcon.Icon = new Icon(AppDomain.CurrentDomain.BaseDirectory + "\\Logo.ico", 40, 40);
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
            trayIcon.DoubleClick += new EventHandler(OnDoubleClick);


            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 60000;
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        //Ctor
        public ApplicationStartUp()
        {
            InitializeComponent();
            SelectAllComponents();

        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            // Release the icon resource.
            trayIcon.Dispose();
            Application.Exit();
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                // Release the icon resource.
                trayIcon.Dispose();
            }
            base.Dispose(isDisposing);
        }
        void NotificationClicked(object sender, MouseEventArgs e)
        {
            if (!AppStarted)
            {
                Visible = true;
                ShowInTaskbar = true;
                AppStarted = true;


                if (componentsToModifiy.Count > 0)
                {
                    this.Search.Text = componentsToModifiy[0].Reference;

                }
            }
        }
        public void SelectAllComponents()
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=C:\\Users\\Stan\\source\\repos\\macdoc\\macdoc\\Files\\MacdocDB.db"))
            {

                Component component;

                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();

                    string CurrentCinfo = System.Globalization.CultureInfo.CurrentCulture.ToString();
                    string CulInfor = "";

                    if (CurrentCinfo.Equals("fr-FR"))
                        CulInfor = "FORMAT(date_modification, 'd', 'en-gb')";

                    else if (CurrentCinfo.Equals("en-US"))
                        CulInfor = "FORMAT(date_modification, 'd', 'en-us')";
                    else
                        CulInfor = "FORMAT(date_modification, 'd', 'iv')";


                    string sqlcommand = "select component.id, component.nom , component.reference , date_insertion as \"date d'insertion\", date_modification as \"date " +
                                      "de modification\" , life_duration as \"durée de vie\" , num_modification as \"nombre de modifications \" , machine.nom,machine.reference from" +
                                      " component inner join machine on machine.id = component.id_machine ;";
                    SQLiteCommand cmd = new SQLiteCommand(sqlcommand, conn);

                    SQLiteDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        string date_insertion = DateTime.Parse(reader.GetString(3)).ToString("dd/MM/yyyy");
                        string date_modification = DateTime.Parse(reader.GetString(4)).ToString("dd/MM/yyyy");


                        component = new Component(reader.GetString(1), reader.GetString(2),
                            DateTime.Parse(date_insertion), DateTime.Parse(date_modification), reader.GetInt32(6), true);

                        component.MachineName = reader.GetString(7);
                        component.MachineRef = reader.GetString(8);

                        if (reader.GetString(5).Contains("Jours"))
                        {
                            //if (component.Date_modification.AddDays(double.Parse(reader.GetString(5).Replace("Jours", "").Trim())) <= DateTime.Now.Date)
                            //    componentsToModifiy.Add(component);
                            if (true)
                            {
                                componentsToModifiy.Add(component);
                            }
                        }
                        else if (reader.GetString(5).Contains("Mois"))
                        {
                            if (component.Date_modification.AddMonths(int.Parse(reader.GetString(5).Replace("Mois", "").Trim())) <= DateTime.Now.Date)
                                componentsToModifiy.Add(component);
                        }
                        else if (reader.GetString(5).Contains("Semaines"))
                        {
                            if (component.Date_modification.AddDays(Math.Round(double.Parse(reader.GetString(5).Replace("Semaines", "").Trim()) * 7)) <= DateTime.Now.Date)
                                componentsToModifiy.Add(component);
                        }
                        else
                        {
                            if (component.Date_modification.AddYears(int.Parse(reader.GetString(5).Replace("Jours", "").Trim())) <= DateTime.Now.Date)
                                componentsToModifiy.Add(component);
                        }




                    }
                    reader.Close();

                    if (componentsToModifiy.Count > 0)
                    {



                        //  MaintenanceNotif.Icon = new System.Drawing.Icon(AppDomain.CurrentDomain.BaseDirectory + "\\Logo.ico");
                        trayIcon.Text = "Cliquez ici pour confirmer l'execution la modification";
                        // trayIcon.Visible = true;

                        trayIcon.BalloonTipTitle = "Macdoc";
                        trayIcon.BalloonTipText = "La Machine " + componentsToModifiy[0].MachineName + " avec la reference " +
                            componentsToModifiy[0].MachineRef + ", Capteur "
                                + componentsToModifiy[0].Name + " avec la reference " + componentsToModifiy[0].Reference + " peut necessiter une maintenane";
                        trayIcon.ShowBalloonTip(500);
                        trayIcon.BalloonTipClicked += MaintenanceNotif_BalloonTipClicked;
                        trayIcon.DoubleClick += MaintenanceNotif_BalloonTipClicked;

                        SendNotification(trayIcon.BalloonTipText);




                    }
                    conn.Close();

                }
                else
                {
                    conn.Close();

                }




                conn.Close();

            }


        }
        private void MaintenanceNotif_BalloonTipClicked(object sender, EventArgs e)
        {

            if (!AppStarted)
            {
                Visible = true;
                ShowInTaskbar = true;
                AppStarted = true;
                RefSearch = true;

                this.Search.Text = componentsToModifiy[0].Reference;

            }

        }

        public void SendNotification(string message)
        {

            var configuration = new Infobip.Api.Client.Configuration()
            {
                BasePath = "https://vvvw3m.api.infobip.com/",
                ApiKeyPrefix = "App",
                ApiKey = "fbced39973294bd59c9edb5f5f2dac1e-f546898  1-0529-4e65-9b4c-1a30750d30b9"
            };

            var sendSmsApi = new SendSmsApi(configuration);

            var smsMessage = new SmsTextualMessage()
            {
                From = "MacDoc",
                Destinations = new List<SmsDestination>()
                {
                    new SmsDestination(to: "+213561253364")
                },
                Text = message
            };

            var smsRequest = new SmsAdvancedTextualRequest()
            {
                Messages = new List<SmsTextualMessage>() { smsMessage }
            };


            try
            {
                var smsResponse = sendSmsApi.SendSmsMessage(smsRequest);

                MessageBox.Show("Message sent , result : " + $"Status: {smsResponse.Messages.First().Status}");

            }
            catch (ApiException apiException)
            {
                var errorCode = apiException.ErrorCode;
                var errorHeaders = apiException.Headers;
                var errorContent = apiException.ErrorContent;

                MessageBox.Show(errorCode.ToString() + "  " + errorHeaders.ToString() + "  " + errorContent.ToString());
            }
            catch (HttpRequestException heept)
            {


            }



        }
    }
}
