using System;
using System.Collections.Generic;
using System.Linq;

namespace ISEKAI_Model
{
    class MysteryEnd : EventCore
    {
        public override int forcedEventPriority { get { return 901; } }
        public override string eventName { get { return "Mystery ���� �̺�Ʈ"; } }
        public override EventLocation location { get { return EventLocation.None; } }
        public override int givenMaxTurn { get { return 10; } }
        public override int cost { get { return 0; } }
        public override Season availableSeason { get { return Season.None; } }
        public override List<Command> script { get { return Parser.ParseScript("Assets/ISEKAI_Model/Scripts/MysteryEnd.txt"); } } // command list.

        protected override bool exclusiveCondition()
        {
            return game.endingGameOverStatus == 0 && game.additionalEndingOption == 0;
        }

        public MysteryEnd(Game game) : base(game)
        {
        }
    }
}