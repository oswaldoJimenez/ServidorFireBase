using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorFireBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       


        private async Task btnPeticion_ClickAsync()
        {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("C:/Users/ajent/Documents/proyectofirebase-c8858-firebase-adminsdk-p7zwp-2dec3156a4.json")
            });

            var registrationToken = "d85ZcfePT8q9sI0-TuUNdK:APA91bE5Gtb3of3t6MRZsBXwNZ8cXwV-vucDqZHnpe74GZzMOyXfBkOs4Ye64GAPqfnOj0Agw9FCo3tIrxldJFi-D-0niouAQ-o_RiqAmFKp_UDo4Twc78eTBpbWbHTxTSCMVxiWopTf";

            var message = new FirebaseAdmin.Messaging.Message()
            {
                Notification = new Notification()
                {
                    Title = "Este es un Titulo de Notificacion",
                    Body = "Hola, este es el contenido del mensaje.",
                },
                Token = registrationToken,
            };

           
            string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);

           
            MessageBox.Show("Successfully sent message: " + response);
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            _ = btnPeticion_ClickAsync();
        }
    }
}
