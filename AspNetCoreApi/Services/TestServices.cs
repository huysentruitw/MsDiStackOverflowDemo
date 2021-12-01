namespace AspNetCoreApi.Services
{
    public class Service1 : IService
    {
        public Service1(Service2 serviceA, Service3 serviceB)
        {
        }
    }

    public class Service2 : IService
    {
        public Service2(Service3 serviceA, Service4 serviceB)
        {
        }
    }

    public class Service3 : IService
    {
        public Service3(Service4 serviceA, Service5 serviceB)
        {
        }
    }

    public class Service4 : IService
    {
        public Service4(Service5 serviceA, Service6 serviceB)
        {
        }
    }

    public class Service5 : IService
    {
        public Service5(Service6 serviceA, Service7 serviceB)
        {
        }
    }

    public class Service6 : IService
    {
        public Service6(Service7 serviceA, Service8 serviceB)
        {
        }
    }

    public class Service7 : IService
    {
        public Service7(Service8 serviceA, Service9 serviceB)
        {
        }
    }

    public class Service8 : IService
    {
        public Service8(Service9 serviceA, Service10 serviceB)
        {
        }
    }

    public class Service9 : IService
    {
        public Service9(Service10 serviceA, Service11 serviceB)
        {
        }
    }

    public class Service10 : IService
    {
        public Service10(Service11 serviceA, Service12 serviceB)
        {
        }
    }

    public class Service11 : IService
    {
        public Service11(Service12 serviceA, Service13 serviceB)
        {
        }
    }

    public class Service12 : IService
    {
        public Service12(Service13 serviceA, Service14 serviceB)
        {
        }
    }

    public class Service13 : IService
    {
        public Service13(Service14 serviceA, Service15 serviceB)
        {
        }
    }

    public class Service14 : IService
    {
        public Service14(Service15 serviceA, Service16 serviceB)
        {
        }
    }

    public class Service15 : IService
    {
        public Service15(Service16 serviceA, Service17 serviceB)
        {
        }
    }

    public class Service16 : IService
    {
        public Service16(Service17 serviceA, Service18 serviceB)
        {
        }
    }

    public class Service17 : IService
    {
        public Service17(Service18 serviceA, Service19 serviceB)
        {
        }
    }

    public class Service18 : IService
    {
        public Service18(Service19 serviceA, Service20 serviceB)
        {
        }
    }

    public class Service19 : IService
    {
        public Service19(Service20 serviceA, Service21 serviceB)
        {
        }
    }

    public class Service20 : IService
    {
        public Service20(Service21 serviceA, Service22 serviceB)
        {
        }
    }

    public class Service21 : IService
    {
        public Service21(Service22 serviceA, Service23 serviceB)
        {
        }
    }

    public class Service22 : IService
    {
        public Service22(Service23 serviceA, Service24 serviceB)
        {
        }
    }

    public class Service23 : IService
    {
        public Service23(Service24 serviceA, Service25 serviceB)
        {
        }
    }

    public class Service24 : IService
    {
        public Service24(Service25 serviceA, Service26 serviceB)
        {
        }
    }

    public class Service25 : IService
    {
        public Service25(Service26 serviceA, Service27 serviceB)
        {
        }
    }

    public class Service26 : IService
    {
        public Service26(Service27 serviceA, Service28 serviceB)
        {
        }
    }

    public class Service27 : IService
    {
        public Service27(Service28 serviceA, Service29 serviceB)
        {
        }
    }

    public class Service28 : IService
    {
        public Service28()
        {
        }
    }

    public class Service29 : IService
    {
        public Service29()
        {
        }
    }

    public interface IService { }    
}