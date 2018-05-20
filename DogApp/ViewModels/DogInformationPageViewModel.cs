using System;
namespace DogApp.ViewModels
{
    public class DogInformationPageViewModel
    {
        public string Name => _name;
        private readonly string _name;

        public string Breed => _breed;
        private readonly string _breed;

        public string Age
        {
            get
            {
                if (_age < 2 && _age != 1.0f)
                {
                    var months = (int)((_age - 1) * 12);
                    return $"1 year {months} months";
                }
                return $"{Math.Truncate(_age)} years";
            }
        }
        private readonly float _age;

        public string Weight => $"{_weight.ToString("N1")} kgs";
        private readonly float _weight;

        public DogInformationPageViewModel()
        {
            _name = "Xoli";
            _breed = "Puli";
            _age = 2.75f;
            _weight = 7.5f;
        }
    }
}
