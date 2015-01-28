//	example of implementing the Abstract Factory pattern

using System;
using Abstract;
using Concrete;

namespace	Abstract
{
	public interface	ISingleEngineAirplane
	{
		void	Fly();
	}

	public interface	IMultiEngineAirplane
	{
		void	Fly();
	}

	public interface	IAirplaneFactory
	{
		ISingleEngineAirplane	CreateSingleEngine();
		IMultiEngineAirplane	CreateMultiEngine();
	}
}

namespace	Concrete
{
	class	CessnaSingleEngine : ISingleEngineAirplane
	{
		public void	Fly()	{	Console.WriteLine("Cessna SEL:  Flying, high wing, great view!");	}
	}

	class	CessnaMultiEngine : IMultiEngineAirplane
	{
		public void	Fly()	{	Console.WriteLine("Cessna MEL:  Nice, smooth flight, FL180!");	}
	}

	class	PiperSingleEngine : ISingleEngineAirplane
	{
		public void	Fly()	{	Console.WriteLine("Piper SEL:  Flying, low wing, great view!");	}
	}

	class	PiperMultiEngine : IMultiEngineAirplane
	{
		public void	Fly()	{	Console.WriteLine("Piper MEL:  Nice, smooth flight, FL220!");	}
	}

	public class	CessnaFactory : IAirplaneFactory
	{
		public ISingleEngineAirplane	CreateSingleEngine()
		{
			return new CessnaSingleEngine();
		}

		public IMultiEngineAirplane	CreateMultiEngine()
		{
			return new CessnaMultiEngine();
		}
	}

	public class	PiperFactory : IAirplaneFactory
	{
		public ISingleEngineAirplane	CreateSingleEngine()
		{
			return new PiperSingleEngine();
		}

		public IMultiEngineAirplane	CreateMultiEngine()
		{
			return new PiperMultiEngine();
		}
	}
}

namespace	Client
{
	public class	TheClient
	{
		static CessnaFactory	m_oCF = new CessnaFactory();
		static PiperFactory	m_oPF = new PiperFactory();

		public static void	Main(string[] args)
		{
			ISingleEngineAirplane	oSE;
			IMultiEngineAirplane	oME;

			Console.WriteLine("Creating Cessna SE, Piper ME...");

			oSE = m_oCF.CreateSingleEngine();
			oME = m_oPF.CreateMultiEngine();

			oSE.Fly();
			oME.Fly();

			Console.WriteLine("Creating Piper SE, Cessna ME...");

			oSE = m_oPF.CreateSingleEngine();
			oME = m_oCF.CreateMultiEngine();

			oSE.Fly();
			oME.Fly();
		}
	}
}
