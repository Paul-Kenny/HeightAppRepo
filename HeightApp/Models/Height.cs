using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HeightApp.Models
{
    public class Height
    {
        const double InchesToMeters = 0.0254;

        [Range(0, int.MaxValue, ErrorMessage = "Feet must be > 0")]
        public int Feet { get; set; }

        [Range(0, 11, ErrorMessage = "Inches must be 0...11")]
        public int Inches { get; set; }

        public double Metric
        {
            get
            {
                return (Feet * 12 + Inches) * InchesToMeters;
            }
        }
    }
}