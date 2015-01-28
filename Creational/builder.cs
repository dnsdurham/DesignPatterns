//	example of implementing the Builder pattern

using System;
using Abstract;
using	Concrete;

namespace	Abstract
{
	public interface	IAirplanePart
	{
		string	Manufacturer	{	get;	}
	}

	public interface	IPartBuilder
	{
		bool	BuildPart();
	}

	public interface	IAirplane
	{
		IAirplanePart	Airframe	{	get;	}
		IAirplanePart	Engine	{	get;	}
	}

	public interface	IAirplaneAssembler
	{
		bool	Construct();
	}
}

namespace	Concrete
{
	public class	ContinentalEngine : IAirplanePart, IPartBuilder
	{
		private const string	MANUFACTURER = "Continental";

		public string	Manufacturer	{	get	{	return MANUFACTURER;	}	}

		public bool	BuildPart()
		{
			Console.WriteLine("Assembling a {0} engine...", MANUFACTURER);

			return true;
		}
	}

	public class	LycomingEngine : IAirplanePart, IPartBuilder
	{
		private const string	MANUFACTURER = "Lycoming";

		public string	Manufacturer	{	get	{	return MANUFACTURER;	}	}

		public bool	BuildPart()
		{
			Console.WriteLine("Assembling a {0} engine...", MANUFACTURER);

			return true;
		}
	}

	public class	C152Airframe : IAirplanePart, IPartBuilder
	{
		private const string	MANUFACTURER = "Cessna 152";

		public string	Manufacturer	{	get	{	return MANUFACTURER;	}	}

		public bool	BuildPart()
		{
			Console.WriteLine("Assembling a {0} airframe...", MANUFACTURER);

			return true;
		}
	}

	public class	C172Airframe : IAirplanePart, IPartBuilder
	{
		private const string	MANUFACTURER = "Cessna 172";

		public string	Manufacturer	{	get	{	return MANUFACTURER;	}	}

		public bool	BuildPart()
		{
			Console.WriteLine("Assembling a {0} airframe...", MANUFACTURER);

			return true;
		}
	}

	public class	C172 : IAirplane, IAirplaneAssembler
	{
		private C172Airframe	m_oAirframe;
		private LycomingEngine	m_oEngine;

		public IAirplanePart	Airframe	{	get	{	return m_oAirframe;	}	}
		public IAirplanePart	Engine	{	get	{	return m_oEngine;	}	}

		public bool	Construct()
		{
			m_oAirframe = new C172Airframe();
			m_oEngine = new LycomingEngine();

			return m_oAirframe.BuildPart() && m_oEngine.BuildPart();
		}
	}
}

namespace	Client
{
	public class	TheClient
	{
		public static void	Main(string[] args)
		{
			C172	o = new C172();

			Console.WriteLine("Constructing a Cessna 172...");

			if (o.Construct())
			{
				Console.WriteLine("Success!");
				Console.WriteLine("Airframe:  {0}", o.Airframe.Manufacturer);
				Console.WriteLine("Engine:  {0}", o.Engine.Manufacturer);
			}
			else	Console.WriteLine("Failed!");
		}
	}
}
