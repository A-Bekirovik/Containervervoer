using System;
using System.Collections.Generic;
using ContainerVervoer;

namespace ContainerVervoer
{
    public class ContainerShip
    {
        List<Container> ContainersOnDock = new List<Container>();

        public void Run()
        {
            ContainerPlacer containerPlacer = new ContainerPlacer(new Ship(6, 3));

            ContainersOnDock.Add(new Container(30, false, true));
            ContainersOnDock.Add(new Container(30, false, true));
            ContainersOnDock.Add(new Container(30, false, true));
            ContainersOnDock.Add(new Container(30, false, true));                                                                                           
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));
            ContainersOnDock.Add(new Container(30, false, false));        
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));


            foreach (Container container in ContainersOnDock)
            {
                containerPlacer.Ship.Containers.Add(container);
            }

            containerPlacer.Ship.Run();
        }
    }
}
