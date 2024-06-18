using System;
namespace ContainerVervoer
{
	public class Scenarios
	{
        List<Container> ContainersOnDock = new List<Container>();

        public Scenarios() 
	    {
        }

        public void Scenario1()
        {
            ContainerPlacer containerPlacer = new ContainerPlacer(new Ship(3, 3));

            ContainersOnDock.Add(new Container(10, true, true));
            ContainersOnDock.Add(new Container(10, true, true));
            ContainersOnDock.Add(new Container(10, false, true));
            ContainersOnDock.Add(new Container(10, false, true));
            ContainersOnDock.Add(new Container(10, false, true));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));
            ContainersOnDock.Add(new Container(10, false, false));

            foreach (Container container in ContainersOnDock)
            {
                containerPlacer.Ship.Containers.Add(container);
            }

            containerPlacer.Ship.Run();
        }

        public void Scenario2()
        {
            ContainerPlacer containerPlacer = new ContainerPlacer(new Ship(6, 3));

            ContainersOnDock.Add(new Container(30, true, true));
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

            foreach (Container container in ContainersOnDock)
            {
                containerPlacer.Ship.Containers.Add(container);
            }

            containerPlacer.Ship.Run();
        }

        public void Scenario3()
        {
            ContainerPlacer containerPlacer = new ContainerPlacer(new Ship(5, 3));

            ContainersOnDock.Add(new Container(30, true, true));
            ContainersOnDock.Add(new Container(30, false, true));
            ContainersOnDock.Add(new Container(30, false, true));
            ContainersOnDock.Add(new Container(30, false, true));
            ContainersOnDock.Add(new Container(30, false, true));
            ContainersOnDock.Add(new Container(30, false, true));
            ContainersOnDock.Add(new Container(30, false, true));
            ContainersOnDock.Add(new Container(30, false, true));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
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

            foreach (Container container in ContainersOnDock)
            {
                containerPlacer.Ship.Containers.Add(container);
            }

            containerPlacer.Ship.Run();
        }

        public void Scenario4()
        {
            ContainerPlacer containerPlacer = new ContainerPlacer(new Ship(2, 3));

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

            foreach (Container container in ContainersOnDock)
            {
                containerPlacer.Ship.Containers.Add(container);
            }

            containerPlacer.Ship.Run();
        }

        public void Scenario5()
        {
            ContainerPlacer containerPlacer = new ContainerPlacer(new Ship(2, 3));

            ContainersOnDock.Add(new Container(30, true, true));
            ContainersOnDock.Add(new Container(30, true, true));
            ContainersOnDock.Add(new Container(30, true, true));
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

            foreach (Container container in ContainersOnDock)
            {
                containerPlacer.Ship.Containers.Add(container);
            }

            containerPlacer.Ship.Run();
        }

        public void Scenario6()
        {
            ContainerPlacer containerPlacer = new ContainerPlacer(new Ship(2, 3));

            ContainersOnDock.Add(new Container(30, true, true));
            ContainersOnDock.Add(new Container(30, true, true));
            ContainersOnDock.Add(new Container(30, true, true));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
            ContainersOnDock.Add(new Container(30, true, false));
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

            foreach (Container container in ContainersOnDock)
            {
                containerPlacer.Ship.Containers.Add(container);
            }

            containerPlacer.Ship.Run();
        }
    }
}

