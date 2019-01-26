﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISEKAI_Model
{
    public class Farming_2 : EventCore
    {
        public override int forcedEventPriority { get { return 0; } }
        public override string eventName { get { return "농사 이벤트 2"; } }
        public override EventLocation location { get { return EventLocation.Field; } }
        public override int givenMaxTurn { get { return -1; } }
        public override int cost { get { return 2; } }
        public override Season availableSeason { get { return Season.Autumn; } }
        public override List<Command> script { get { return Parser.ParseScript("Assets/ISEKAI_Model/Scripts/Farming_2.txt"); } } // command list.

        protected override bool exclusiveCondition()
        {
            return game.allEventsList.Find(e => e.eventName.Equals("농사 이벤트 1")).status == EventStatus.Completed;
        }

        public Farming_2(Game game) : base(game)
        {

        }
    }
}