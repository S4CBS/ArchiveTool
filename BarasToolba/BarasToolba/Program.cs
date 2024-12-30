using System.Media;
using BarasToolba;

namespace BarasToolba
{
    public static class Media
    {
        static System.Media.SoundPlayer player = new System.Media.SoundPlayer(FiddlerCore.wavFolderPath);
        public static void playSound()
        {
            player.Play();
        }
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form());
        }

        internal static void RoleSpoffer()
        {
            // �������� ������� ����.
            var role = Globals_Session.Game.playerRole.ToString();

            if (role != "None")
            {
                if (role == "Survivor")
                {
                    Globals_Session.Game.playerRole = Globals_Session.Game.E_PlayerRole.Killer;
                    Form.PlayerRole.Text = $"����: {Globals_Session.Game.playerRole.ToString()}";
                }
                else if (role == "Killer")
                {
                    Globals_Session.Game.playerRole = Globals_Session.Game.E_PlayerRole.Survivor;
                    Form.PlayerRole.Text = $"����: {Globals_Session.Game.playerRole.ToString()}";
                }
            }
            else
            {
                MessageBox.Show("�� �� � �����", "������� �� �������.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}