using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeletonShimmer
{
    class List
    {
        public List(int id, string name, string description)
        { 
            PhotoId = id;
            Fname = name;
            Fdescription = description;

        }

        public int PhotoId { get; }
        public string Fname { get; }
        public string Fdescription { get; }
    }
    class Details
    {

        static List[] frnd = {

            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            new List(Resource.Drawable.piclock,"Lock","the Lock"),
            };

        private List[] mfrnd;

        Random random;

        public Details()
        {
            mfrnd = frnd;
            random = new Random();
        }

        public int NumbList
        {

            get { return mfrnd.Length; }
        }

        public List this[int i]
        {
            get { return mfrnd[i]; }
        }

        public int RandomSwap()
        {
            List tempfrnd = mfrnd[0];

            int mrandom = random.Next(1, mfrnd.Length);

            mfrnd[0] = mfrnd[mrandom];
            mfrnd[mrandom] = tempfrnd;

            return mrandom;
        }

        public void Suffle()
        {
            for (int i = 0; i < mfrnd.Length; i++)
            {
                List tempfrnd = mfrnd[i];             

                int mrandom = random.Next(1, mfrnd.Length);

                mfrnd[i] = mfrnd[mrandom];
                mfrnd[mrandom] = tempfrnd;
            }
        }
    }
}