//	example of implementing the Factory Method pattern

using System;
using Abstract;
using	Concrete;

namespace	Abstract
{
	public interface	IAirplane
	{
		void	Fly();
	}

	public interface	IAirplaneFactory
	{
		IAirplane	Create(int t);
	}
}

namespace	Concrete
{
	class	CessnaSingleEngine : IAirplane
	{
		public void	Fly()	{	Console.WriteLine("Cessna SEL:  Flying, high wing, great view!");	}
	}

	class	CessnaMultiEngine : IAirplane
	{
		public void	Fly()	{	Console.WriteLine("Cessna MEL:  Nice, smooth flight, FL180!");	}
	}

	class	PiperSingleEngine : IAirplane
	{
		public void	Fly()	{	Console.WriteLine("Piper SEL:  Flying, low wing, great view!");	}
	}

	class	PiperMultiEnginePressurized : IAirplane
	{
		public void	Fly()	{	Console.WriteLine("Piper MEL:  Nice, pressurized smooth flight, FL220!");	}
	}

	public class	CessnaFactory : IAirplaneFactory
	{
		public const int	SEL = 1;
		public const int	MEL = 2;

		public virtual IAirplane	Create(int t)
		{
			switch (t)
			{
				case	SEL:	return new CessnaSingleEngine();
				case	MEL:	return new CessnaMultiEngine();
				default:	throw new Exception("Unknown Aircraft Type!");
			}
		}
	}

	public class	PiperFactory : IAirplaneFactory
	{
		public const int	SEL = 1;
		public const int	MELPRESS = 2;

		public virtual IAirplane	Create(int t)
		{
			switch (t)
			{
				case	SEL:	return new PiperSingleEngine();
				case	MELPRESS:	return new PiperMultiEnginePressurized();
				default:	throw new Exception("Unknown Aircraft Type!");
			}
		}
	}

	class	CessnaCitation : IAirplane
	{
		public void	Fly()	{	Console.WriteLine("Cessna MEL:  Turbines rule!");	}
	}

	public class BetterCessnaFactory : CessnaFactory
	{
		public const int CITATION = MEL + 1;

		override public IAirplane	Create(int t)
		{
			try
			{
				return base.Create(t);
			}
			catch
			{
				switch (t)
				{
					case	CITATION:	return new CessnaCitation();
					default:	throw new Exception("Unknown Aircraft Type!");
				}
			}
		}
	}
}

namespace	Client
{
	public class	TheClient
	{
		static BetterCessnaFactory m_oCF = new BetterCessnaFactory();
		static PiperFactory	m_oPF = new PiperFactory();

		public static void	Main(string[] args)
		{
			IAirplane	o;

			Console.WriteLine("Creating Cessna SE...");

			o = m_oCF.Create(BetterCessnaFactory.SEL);

			o.Fly();

			Console.WriteLine("Creating Piper ME...");

			o = m_oPF.Create(PiperFactory.MELPRESS);

			o.Fly();

			Console.WriteLine("Creating Cessna Citation...");

			o = m_oCF.Create(BetterCessnaFactory.CITATION);

			o.Fly();
		}
	}
}
