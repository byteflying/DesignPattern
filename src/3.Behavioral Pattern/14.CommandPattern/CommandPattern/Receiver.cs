using System;

namespace CommandPattern {

    public abstract class Receiver {

        public CommandArgs CommandArgs { get; set; }

        protected const string LINE_BREAK =
            "-------------------------" +
            "-------------------------";
        //文章排版需要，故折成2行

    }

}