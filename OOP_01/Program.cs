namespace OOP_01
{
    #region Question 1
    //public struct DeliveryAddress
    //{
    //    public string City;
    //    public string Street;
    //}
    //public class Customer
    //{
    //    public string name;
    //}
    #endregion
    #region Question 2
    ////A)1. All the feilds are public,So any code outside the struct can have a direct access and change the values
    ////2. No validation (User can give negative values)
    ////3. can deal with the feilds through properties

    ////B)
    //public struct Shipment
    //{
    //    private string description;
    //    private double weight;
    //    private decimal deliveryFee;

    //    public string Description
    //    {
    //        get { return description; }
    //        set { description = value; }
    //    }
    //    public double Weight { 
    //    get { return weight; }
    //        set 
    //        {
    //            {
    //                if (value >= 0)
    //                    weight = value;
    //            }
    //        }
    //    }
    //    public decimal DeliveryFee
    //    {
    //        get { return deliveryFee; }
    //        set
    //        {
    //            if (value >= 0)
    //                deliveryFee = value;
    //        }
    //    }
    //    //the feilds became private no one can access it from outside,Can deal with feild through property

    //}
    #endregion
    #region Part2 1. DeliveryAddress struct
    //public struct DeliveryAddress
    //{
    //    public string City;
    //    public string Street;
    //    public int BuildingNumber;

    //    public DeliveryAddress(string city, string street, int buildingNumber)
    //    {
    //        City = city;
    //        Street = street;
    //        BuildingNumber = buildingNumber;
    //    }

    //    public string GetFullAddress()
    //    {
    //        return $"BuildingNumber: {BuildingNumber} Street: {Street} City: { City}";
    //    }
    //}
    #endregion
    #region Part2 2. Shipment struct
    //public struct Shipment
    //{
    //    private string trackingCode;
    //    private string description;
    //    private double weight;
    //    private decimal deliveryFee;

    //    public DeliveryAddress Destination { get; set; }

    //    public string TrackingCode
    //    {
    //        get { return trackingCode; }
    //    }

    //    public string Description
    //    {
    //        get { return description; }
    //        set
    //        {
    //            if (!string.IsNullOrWhiteSpace(value))
    //            {
    //                description = value;
    //            }
    //        }
    //    }

    //    public double Weight
    //    {
    //        get { return weight; }
    //        set
    //        {
    //            if (value > 0)
    //            {
    //                weight = value;
    //            }
    //        }
    //    }

    //    public decimal DeliveryFee
    //    {
    //        get { return deliveryFee; }
    //        private set
    //        {
    //            if (value > 0)
    //            {
    //                deliveryFee = value;
    //            }
    //        }
    //    }

    //    public decimal EstimatedCost
    //    {
    //        get { return DeliveryFee + (decimal)(Weight * 5); }
    //    }
    //    public Shipment(string trackingCode)
    //    {
    //        if (string.IsNullOrWhiteSpace(trackingCode))
    //        {
    //            Console.WriteLine("cannot be empty");
    //        }

    //        this.trackingCode = trackingCode;
    //        description = "Unknown";
    //        weight = 1;
    //        deliveryFee = 50;
    //        Destination = new DeliveryAddress("Unknown", "Unknown", 0);
    //    }

    //    public Shipment(
    //        string trackingCode,
    //        string description,
    //        double weight,
    //        decimal deliveryFee,
    //        DeliveryAddress destination)
    //    {
    //        if (string.IsNullOrWhiteSpace(trackingCode))
    //        {
    //            throw new ArgumentException("Tracking code cannot be empty.");
    //        }

    //        this.trackingCode = trackingCode;

    //        this.description = "Unknown";
    //        this.weight = 1;
    //        this.deliveryFee = 50;

    //        if (!string.IsNullOrWhiteSpace(description))
    //        {
    //            this.description = description;
    //        }

    //        if (weight > 0)
    //        {
    //            this.weight = weight;
    //        }

    //        if (deliveryFee > 0)
    //        {
    //            this.deliveryFee = deliveryFee;
    //        }

    //        Destination = destination;


    //    }
    //    public void UpdateDeliveryFee(decimal newFee)
    //    {
    //        if (newFee > 0)
    //        {
    //            DeliveryFee = newFee;
    //        }
    //    }

    //    public void PrintShipment()
    //    {
    //        Console.WriteLine("Tracking Code: " + TrackingCode);
    //        Console.WriteLine("Description: " + Description);
    //        Console.WriteLine("Weight: " + Weight + " KG");
    //        Console.WriteLine("Delivery Fee: " + DeliveryFee + " EGP");
    //        Console.WriteLine("Destination: " + Destination.GetFullAddress());
    //        Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
    //    }
    //}

    #endregion
    #region part 2 5 Delivery center struct
    //public struct DeliveryCenter
    //{
    //    private Shipment[] shipments;

    //    public DeliveryCenter()
    //    {
    //        shipments = new Shipment[10];
    //    }

    //    public Shipment this[int index]
    //    {
    //        get
    //        {
    //            if (index >= 0 && index < shipments.Length)
    //            {
    //                return shipments[index];
    //            }

    //            return default;
    //        }

    //        set
    //        {
    //            if (index >= 0 && index < shipments.Length)
    //            {
    //                shipments[index] = value;
    //            }
    //        }
    //    }
    //    public Shipment this[string trackingCode]
    //    {
    //        get
    //        {
    //            for (int i = 0; i < shipments.Length; i++)
    //            {
    //                if (shipments[i].TrackingCode == trackingCode)
    //                {
    //                    return shipments[i];
    //                }
    //            }

    //            return default;
    //        }
    //    }
    //    public bool AddShipment(Shipment shipment)
    //    {
    //        for (int i = 0; i < shipments.Length; i++)
    //        {
    //            if (string.IsNullOrEmpty(shipments[i].TrackingCode))
    //            {
    //                shipments[i] = shipment;
    //                return true;
    //            }
    //        }

    //        return false;
    //    }
    //}

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 Object creation
            //DeliveryAddress address = new DeliveryAddress();

            //address.City = "Cairo";
            //address.Street = "Main";
            //DeliveryAddress address2 = address;
            //address2.City = "Alexandria";
            //Console.WriteLine(address2.City);
            //Console.WriteLine(address.City);
            ////struct is a value type the value is simply just copied to the other variable 

            //Customer customer1 = new Customer();
            //customer1.name = "Ahmed";

            //Customer customer2 = customer1;

            //customer2.name = "Ali";

            //Console.WriteLine(customer1.name);
            ////class is a reference type,So both customer references refers to the same object
            #endregion
            #region Part2 1. DeliveryAddress struct
            //DeliveryAddress address0 = new DeliveryAddress();
            //address0.City = "mansoura";
            //DeliveryAddress address2 = address0;
            //address2.City = "cairo";
            //Console.WriteLine(address2.City);
            //Console.WriteLine(address0.City);
            #endregion
            #region Part 2 - Question 6
            //DeliveryCenter center = new DeliveryCenter();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter Shipment " + (i + 1));

            //    Console.Write("Tracking Code: ");
            //    string trackingCode = Console.ReadLine();

            //    Console.Write("Description: ");
            //    string description = Console.ReadLine();

            //    Console.Write("Weight: ");
            //    double weight = double.Parse(Console.ReadLine());

            //    Console.Write("Delivery Fee: ");
            //    decimal deliveryFee = decimal.Parse(Console.ReadLine());

            //    Console.Write("City: ");
            //    string city = Console.ReadLine();

            //    Console.Write("Street: ");
            //    string street = Console.ReadLine();

            //    Console.Write("Building Number: ");
            //    int buildingNumber = int.Parse(Console.ReadLine());

            //    DeliveryAddress address =
            //        new DeliveryAddress(city, street, buildingNumber);

            //    Shipment shipment =
            //        new Shipment(
            //            trackingCode,
            //            description,
            //            weight,
            //            deliveryFee,
            //            address);

            //    center.AddShipment(shipment);

            //    Console.WriteLine();
            //}

            //Console.WriteLine("three Shipments:");
            //for (int i = 0; i < 3; i++)
            //{
            //    center[i].PrintShipment();

            //    Console.WriteLine();
            //}


            //Console.Write("Enter Tracking Code: ");
            //string searchCode = Console.ReadLine();

            //Shipment foundShipment = center[searchCode];

            //if (!string.IsNullOrEmpty(foundShipment.TrackingCode))
            //{
            //    Console.WriteLine(
            //        "Shipment found: " +
            //        foundShipment.TrackingCode +
            //        " - " +
            //        foundShipment.Description);
            //}
            //else
            //{
            //    Console.WriteLine("Shipment not found.");
            //}

            //DeliveryAddress originalAddress =new DeliveryAddress("Cairo", "Tahrir Street", 15);
            //DeliveryAddress copiedAddress = originalAddress;
            //copiedAddress.Street = "Hai elgam3aa";
            //copiedAddress.BuildingNumber = 20;
            //Console.WriteLine("Struct Copy");
            //Console.WriteLine($"Original Address: { originalAddress.GetFullAddress()}");
            //Console.WriteLine($"Copied Address: {copiedAddress.GetFullAddress()}");
            #endregion
        }
    }
}
