using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DecodeTietoEI.Zad
{
    class Zad4
    {
        public int result=0;
        private List<Cloud> clouds = new List<Cloud>();
        public void Run()
        {
            Fill();
            for (int i = 0; i < 10000; i++)
            {
                foreach (var cloud in clouds)
                {
                    Move(cloud);
                    int count = 0;
                    foreach (var pCloud in clouds)
                    {
                        if (pCloud.id != cloud.id)
                        {
                            if (pCloud.posX == cloud.posX && pCloud.posY == cloud.posY)
                            {
                                count++;
                            }
                        }
                    }
                    if (count == 1)
                    {
                        result++;
                    }
                }
            }
        }
        private void Move(Cloud c)
        {
            c.posX += c.speedX;
            if (c.posX >= 360)
                c.posX -= 360;
            else if (c.posX < 0)
                c.posX += 360;

            c.posY += c.speedY;
            if (c.posY >= 360)
                c.posY -= 360;
            else if (c.posY < 0)
                c.posY += 360;
        }
        public void Fill()
        {
            clouds.Add(new Cloud()
            {
                id = 1,
                posX = 0,
                posY = 1,
                speedX = 1,
                speedY = -1
            });
            clouds.Add(new Cloud()
            {
                id = 2,
                posX = 0,
                posY = 0,
                speedX = 1,
                speedY = 1
            });
            clouds.Add(new Cloud()
            {
                id = 3,
                posX = 358,
                posY = 0,
                speedX = 3,
                speedY = 1
            });
            clouds.Add(new Cloud()
            {
                id = 4,
                posX = 1,
                posY = 1,
                speedX = 0,
                speedY = -1
            });
            clouds.Add(new Cloud()
            {
                id = 5,
                posX = 2,
                posY = 2,
                speedX = -1,
                speedY = -2
            });
        }
        class Cloud
        {
            public int id;
            public int posX, posY;
            public int speedX, speedY;
        }
    }
}
