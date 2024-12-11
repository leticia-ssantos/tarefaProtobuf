using System;
using System.Windows.Forms;
using Shared.Protos;
using Shared.Connection;

namespace Client
{
    public partial class Client : Form
    {
        private readonly Greeter.GreeterClient _client;

        public Client()
        {
            InitializeComponent();
            IGrpcConnection connection;
            connection = new GrpcConnection("http://localhost:5000");
            _client = new Greeter.GreeterClient(connection.Channel);
        }

        private async void BtCadastro_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Chamada ao método SayHello
                var helloRequest = new HelloRequest { Text = tbName.Text };
                var helloReply = await _client.SayHelloAsync(helloRequest);

                // Exibe a resposta do SayHello
                lbSayHello.Visible = true;
                lbSayHello.Text = helloReply.Message;

                // Chamada ao método GetTime
                var timeRequest = new TimeRequest();
                var timeReply = await _client.GetTimeAsync(timeRequest);

                // Exibe a resposta do GetTime
                lbGetTime.Visible = true;
                lbHora.Visible = true;
                lbHora.Text = timeReply.Hour.ToString() + ":" + timeReply.Minute.ToString() + ":" + timeReply.Second.ToString();
            }
            catch (Exception ex)
            {
                // Exibe erros caso ocorram
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
