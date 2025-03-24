class ConsoleApp1
{
    static void Main(string[] args)
    {
        var vessel1 = new ContainerVessel(12,100,1000,new List<Container>());
        var contener = new L(100.0, 2.5, 50, 4, 200);
        var contener2 = new C(100.0, 2.5, 50, 4, 200,24);

        vessel1.LoadContainerOntoShip(contener);
      
        
    }
}