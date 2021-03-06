﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class Glass: Filters
    {
        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {
            Random rand = new Random();
            int positionX = (int)(x + (rand.Next(1) - 0.5f) * 10);
            int positionY = (int)(y + (rand.Next(1) - 0.5f) * 10);

            //positionX = clamp(positionX, 0, sourceMap.Width);
            //positionY = clamp(positionY, 0, sourceMap.Height);
            if (positionX < sourceMap.Width && positionX > 0 && positionY < sourceMap.Height && positionY > 0)
            {
                Color c = sourceMap.GetPixel(positionX, positionY);
                return c;
            }
            else
            {
               Color c = Color.FromArgb(255, 255, 255);
                return c;
            }
            throw new NotImplementedException();
        }
        
    }
}
