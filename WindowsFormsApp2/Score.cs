
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
public class Wynik
{
    public static int Score { get; set; }
    public static int Points { get; set; }

    public Wynik()
    {
        Score = 0;
        Points = 10;
    }
        
}
}

