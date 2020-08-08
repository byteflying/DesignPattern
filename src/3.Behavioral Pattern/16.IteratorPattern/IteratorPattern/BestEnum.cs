using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern {

    public class BestEnum {

        public static IEnumerable<ApplePhone> GetIPhones() {
            yield return new ApplePhone {
                PhoneName = "IPhone",
                PublishedDate = new DateTime(2007, 1, 9)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 3G",
                PublishedDate = new DateTime(2008, 6, 10)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 3GS",
                PublishedDate = new DateTime(2009, 6, 9)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 4",
                PublishedDate = new DateTime(2010, 6, 8)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 4s",
                PublishedDate = new DateTime(2011, 10, 4)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 5",
                PublishedDate = new DateTime(2012, 9, 13)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 5S",
                PublishedDate = new DateTime(2013, 9, 10)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 5C",
                PublishedDate = new DateTime(2013, 9, 10)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 6",
                PublishedDate = new DateTime(2014, 9, 10)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 6 Plus",
                PublishedDate = new DateTime(2014, 9, 10)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 6s",
                PublishedDate = new DateTime(2015, 9, 10)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 6s Plus",
                PublishedDate = new DateTime(2015, 9, 10)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 7",
                PublishedDate = new DateTime(2016, 9, 8)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 7 Plus",
                PublishedDate = new DateTime(2016, 9, 8)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 8",
                PublishedDate = new DateTime(2017, 9, 13)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone 8 Plus",
                PublishedDate = new DateTime(2017, 9, 13)
            };
            yield return new ApplePhone {
                PhoneName = "IPhone X",
                PublishedDate = new DateTime(2017, 9, 13)
            };
        }

    }

}