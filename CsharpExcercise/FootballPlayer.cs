using System;

namespace CsharpExcercise
{
	public class FootballPlayer
	{
		private string _name;
		private double _price;
		private int _shirtNumber;
		private int _id;

		public FootballPlayer()
		{
			_name = Name;
			_price = Price;
			_shirtNumber = ShirtNumber;
			_id = ID;
		}

		public int ID
		{
			get => _id;
			set => _id = value;
			
		}

		public string Name
		{
			get => _name;
			set
			{
				if (value.Length < 4) throw new ArgumentException();
				{
					_name = value;
				}
			}
		}

		public double Price
		{
			get => _price;
			set
			{
				if (value < 0) throw new ArgumentOutOfRangeException();
				{
					_price = value;
				}
			}
		}

		public int ShirtNumber
		{
			get => _shirtNumber;
			set
			{
				if (value <= 1 || value >= 100) throw new ArgumentOutOfRangeException();
				{
					_shirtNumber = value;
				}
			}
		}
	}
}
