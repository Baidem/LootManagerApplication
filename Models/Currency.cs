using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Currency
    {
        USD, // US Dollar
        EUR, // Euro
        JPY, // Japanese Yen
        GBP, // British Pound
        CHF, // Swiss Franc
        AUD, // Australian Dollar
        CAD, // Canadian Dollar
        CNY, // Chinese Yuan
        HKD, // Hong Kong Dollar
        SGD // Singapore Dollar   
    }
}
