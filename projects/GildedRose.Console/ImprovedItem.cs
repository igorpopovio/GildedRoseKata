﻿namespace GildedRose.Console
{
    public abstract class ImprovedItem : Item
    {
        protected ImprovedItem(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public void DecreaseSellIn()
        {
            SellIn--;
        }

        public void DropQuality()
        {
            Quality = 0;
        }

        public void IncreaseQuality()
        {
            if (Quality < 50) Quality++;
        }

        public void DecreaseQuality()
        {
            if (Quality > 0) Quality--;
        }

        public bool IsExpired
        {
            get { return SellIn < 0; }
        }

        public abstract void UpdateQuality();
    }
}
