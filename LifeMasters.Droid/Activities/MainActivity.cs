using Android.App;
using Android.OS;
using Android.Content.PM;
using LifeMasters.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Content.Res;
using Android.Support.V4.Widget;

namespace LifeMasters.Droid.Activities
{
    [Activity(Label = "Life Masters", Icon = "@drawable/icon",
        LaunchMode = LaunchMode.SingleTop, ScreenOrientation = ScreenOrientation.Portrait,
        Name = "lifemasters.droid.activities.MainActivity")]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        private DrawerLayout _drawerLayout;
        private MvxActionBarDrawerToggle _drawerToggle;
        private FragmentManager _fragmentManager;

        internal DrawerLayout DrawerLayout { get { return _drawerLayout; } }

        static MainActivity instance = new MainActivity();

        public static MainActivity CurrentActivity => instance;


        // TODO: determine if this is needed
        //
        //public new MainViewModel ViewModel
        //{
        //    get { return base.ViewModel; }
        //    set { base.ViewModel = value; }
        //}

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _fragmentManager = FragmentManager;

            //SetContentView(Resource.Layout.MainView);

            //var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);

            //_drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            //_drawerLayout.SetDrawerShadow(Resource.Drawable.drawer_shadow_light, (int)GravityFlags.Start);
            //_drawerToggle = new MvxActionBarDrawerToggle(this, _drawerLayout,
            //                    Resource.String.drawer_open, Resource.String.drawer_close);
            //_drawerToggle.DrawerClosed += _drawerToggle_DrawerClosed;
            //_drawerToggle.DrawerOpened += _drawerToggle_DrawerOpened;

            SupportActionBar.SetDisplayShowTitleEnabled(false);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            _drawerToggle.DrawerIndicatorEnabled = true;
            _drawerLayout.DrawerOpened += _drawerLayout_DrawerOpened;
            _drawerLayout.DrawerClosed += _drawerLayout_DrawerClosed;

            //ViewModel.ShowMenu();
        }

        private void _drawerLayout_DrawerClosed(object sender, DrawerLayout.DrawerClosedEventArgs e)
        {
            InvalidateOptionsMenu();
        }

        private void _drawerLayout_DrawerOpened(object sender, DrawerLayout.DrawerOpenedEventArgs e)
        {
            InvalidateOptionsMenu();
        }

        private void _drawerToggle_DrawerClosed(object sender, ActionBarDrawerEventArgs e)
        {
            InvalidateOptionsMenu();
        }

        //public override void OnBeforeFragmentChanging(IMvxCachedFragmentInfo fragmentInfo, FragmentTransaction transaction)
        //{
        //    var currentFrag = SupportFragmentManager.FindFragmentById(Resource.Id.content_frame) as MvxFragment;

        //    if (currentFrag != null && fragmentInfo.ViewModelType != typeof(MenuViewModel)
        //        && currentFrag.FindAssociatedViewModelType() != fragmentInfo.ViewModelType)
        //        fragmentInfo.AddToBackStack = true;
        //    base.OnBeforeFragmentChanging(fragmentInfo, transaction);
        //}

        internal void CloseDrawerMenu()
        {
            _drawerLayout.CloseDrawers();
        }

        //public override bool OnOptionsItemSelected(IMenuItem item)
        //{
        //    if (_drawerToggle.OnOptionsItemSelected(item))
        //    {
        //        return true;
        //    }

        //    return base.OnOptionsItemSelected(item);
        //}

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            base.OnPostCreate(savedInstanceState);
            _drawerToggle.SyncState();
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            _drawerToggle.SyncState();
        }
    }
}

