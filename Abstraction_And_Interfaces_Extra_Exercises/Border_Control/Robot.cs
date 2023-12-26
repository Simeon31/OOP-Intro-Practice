using System;
using System.Collections.Generic;

namespace Border_Control
{
    class Robot : RobotCredentials, ICheckRobot
    {
        public Robot(string model, long id) : base(model, id) { }

        public override void CheckForFalsifiedID(int id)
        {
            base.CheckForFalsifiedID(id);
        }

        public void CheckRobot(Robot robot, int digitToCheck)
        {
               robot.CheckForFalsifiedID(digitToCheck);
        }

        //public static void CheckRobot(List<Robot> robots, int digitToCheck)
        //{
        //    foreach (Robot robot in robots)
        //    {
        //        robot.CheckForFalsifiedID(digitToCheck);
        //    }
        //}
    }
}
