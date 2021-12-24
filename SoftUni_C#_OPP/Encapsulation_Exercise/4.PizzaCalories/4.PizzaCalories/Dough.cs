using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PizzaCalories
{
    public class Dough
    {
        private string flourType;

        private string bakingTechnique;

        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }


        public double Weight
        {
            get => weight;
            private set
            {
                if (value<1||value>200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value; 

            }
        }


        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (!allBakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;

            }
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (!allFlourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                    
                }
               
                flourType = value; 

            }
        }
        private Dictionary<string, double> allFlourTypes = new Dictionary<string, double>()
        {
            {"white", 1.5},
            {"wholegrain", 1.0}
        };
        private Dictionary<string, double> allBakingTechniques = new Dictionary<string, double>()
        {
            {"crispy", 0.9},
            {"chewy", 1.1},
            {"homemade", 1.0}
        };

        public double GetCaloriesDough()
        {
            double result = (2 * weight * allFlourTypes[flourType.ToLower()] * allBakingTechniques[bakingTechnique.ToLower()]);
            return result;
        }
    }
}
