﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallongeCSharpDriver {
    public class Match {
        public int id { get; set; }
        public string identifier { get; set; }
        public Nullable<int> player1_id { get; set; }
        public Nullable<int> player2_id { get; set; }
        private string currentState;
        public MatchState matchState;
        public string state {
            get {
                return currentState;   
            } 
            set {
                currentState = value;
                switch (value) {
                    case "open":
                        matchState = MatchState.Open;
                        break;
                    case "complete":
                        matchState = MatchState.Complete;
                        break;
                    case "pending":
                        matchState = MatchState.Pending;
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
        public override string ToString() {
            return "Match #" + id + ", " + currentState;
        }
    }
}
