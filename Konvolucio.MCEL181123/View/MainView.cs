using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konvolucio.MCEL181123.View
{
    public partial class MainView : UserControl
    {
        private readonly ConnectionNode _connectionPanel;
        private readonly CalibrationNode _calibrationNode;
        private readonly FunctionsNode _measurementsNode;


        private readonly UserControl[] _ctrlPanels;

        public MainView()
        {
            InitializeComponent();

            _ctrlPanels = new UserControl[]
            {
                _connectionPanel = new ConnectionNode() { Dock = DockStyle.Fill },
                _calibrationNode = new CalibrationNode() { Dock = DockStyle.Fill },
                _measurementsNode = new FunctionsNode() { Dock = DockStyle.Fill },
            };

        }

        private void TreeViewNavigator_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedPanel = _ctrlPanels.FirstOrDefault(n => n.Name == e.Node.Name);
            if (selectedPanel != null)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(selectedPanel);
                if (selectedPanel is IUIPanelProperties)
                {
                    (selectedPanel as IUIPanelProperties).UiUpdate();
                }
            }
        }
    }
}
