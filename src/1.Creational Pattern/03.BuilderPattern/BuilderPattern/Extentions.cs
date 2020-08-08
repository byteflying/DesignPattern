using System;
using System.Reflection;
using System.Linq;

namespace BuilderPattern {

    public static class Extentions {

        public static string VehicleInfo(this Vehicle vehicle) {
            var type = vehicle.GetType();
            var properties = type.GetProperties();
            var result = string.Empty;
            foreach (var prop in properties) {
                result +=
                    $"{prop.Name}:{prop.GetValue(vehicle, null)}{Environment.NewLine}";
            }
            return result;
        }

    }

}