using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Supercharge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonShimmer 
{ 
    class AdapterList : RecyclerView.Adapter
    {
        private Details Detail;
        private Context context;

        public AdapterList(Details Details, Context context)
        {
            Detail = Details;
            this.context = context;
        }

        public override int ItemCount => Detail.NumbList;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MyViewHolder viewHolder = holder as MyViewHolder;
            viewHolder.Binddata(Detail, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.list, parent, false);
            return new MyViewHolder(view);
        }
    }
    class MyViewHolder : RecyclerView.ViewHolder
    {
        public ImageView Image;
        public TextView NameText;
        public TextView Description;
        public ShimmerLayout ShimmerLayout;
        public RelativeLayout relativeLayout2;
        public MyViewHolder(View itemView) : base(itemView)
        {
            Image = itemView.FindViewById<ImageView>(Resource.Id.imageView);
            NameText = itemView.FindViewById<TextView>(Resource.Id.firendnameText);
            Description = itemView.FindViewById<TextView>(Resource.Id.frienddescriptionText);
            ShimmerLayout = itemView.FindViewById<ShimmerLayout>(Resource.Id.shimmerLayout);
            relativeLayout2 = itemView.FindViewById<RelativeLayout>(Resource.Id.relativeLayout2);

            StartShimmer();
        }

        private async void StartShimmer()
        {
            ShimmerLayout.Visibility = ViewStates.Visible;
            ShimmerLayout.StartShimmerAnimation();
            await StopShimmer();
        }

        private async Task StopShimmer()
        {
            await Task.Delay(5000);
            relativeLayout2.Visibility = ViewStates.Visible;
            ShimmerLayout.Visibility = ViewStates.Invisible;

        }

        internal void Binddata(Details Detail, int position)
        {
            Image.SetImageResource(Detail[position].PhotoId);
            NameText.Text = Detail[position].Fname;
            Description.Text = Detail[position].Fdescription;
        }
    }
}