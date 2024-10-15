using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.CLS
{
   
        class AppManager : ApplicationContext
        {
            private void SplahScreen()
            {
                try
                {
                    GUI.Splash F = new GUI.Splash();
                    F.ShowDialog();
                }
                catch (Exception)
                {

                }
            }

            private Boolean LoginScreen()
            {
                bool resultado = false;

                try
                {
                    GUI.Login F = new GUI.Login();

                    F.ShowDialog();

                    resultado = F.Autorizado;
                }
                catch (Exception)
                {
                    resultado = false;
                }

                return resultado;
            }

            public AppManager()
            {
             SplahScreen();

                if (LoginScreen())
                {
                    Principal f = new Principal();
                    f.Show();
                }
            }
           
            public void SesionLogin()
            {
                if (LoginScreen()) {
                        Principal f = new Principal();
                        f.Show();
                }
            }

        }



}
