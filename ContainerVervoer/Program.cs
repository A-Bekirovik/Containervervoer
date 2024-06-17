using System;
using System.Collections.Generic;
using ContainerVervoer;

namespace ContainerVervoer
{
    public partial class ContainerShip
    {

        List<Container> FormContainers = new List<Container>();

        public ContainerShip()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            ContainerPlacer containerPlacer = new ContainerPlacer(new Ship(6, 3));

            FormContainers.Add(new Container(30, true, false));

            foreach (Container container in FormContainers)
            {
                containerPlacer.Ship.Containers.Add(container);
            }

            containerPlacer.Ship.Run();
        }
    }
}