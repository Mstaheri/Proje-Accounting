using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
namespace CarpetCompanyDAL
{
    public class SqlTableRefresh : IDisposable
    {
        public static SqlTableRefresh instance;
        public static SqlTableRefresh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SqlTableRefresh();
                }
                return instance;
            }
        }
        public event EventHandler<HesabMali> malRefresh;
        public event EventHandler<VarizBeHesab> varizRefresh;
        public event EventHandler<PardakhtAzHesab> pardakhtRefresh;
        public event EventHandler<AsnadeDaryafti> asnadeDaryaftiRefresh;
        public event EventHandler<Senad> senadRefresh;
        public event EventHandler<AsnadePardakhti> asnadePardakhtiRefresh;
        public event EventHandler<HazineEdari> HazineEdariRefresh;
        public event EventHandler<Hoghogh> hoghoghRefresh;
        SqlTableDependency<HesabMali> hesabMaliDependency;
        SqlTableDependency<VarizBeHesab> varizBeHesabDependency;
        SqlTableDependency<PardakhtAzHesab> pardakhtAzHesabDependency;
        SqlTableDependency<AsnadeDaryafti> asnadeDaryaftiDependency;
        SqlTableDependency<AsnadePardakhti> asnadePardakhtiDependency;
        SqlTableDependency<Senad> senadDependency;
        SqlTableDependency<HazineEdari> hazineEdariDependency;
        SqlTableDependency<Hoghogh> hoghoghDependency;
        private SqlTableRefresh()
        {
            // حساب ها
            hesabMaliDependency = new SqlTableDependency<HesabMali>(Properties.Settings.Default.CarpetCompanyConnectionString,notifyOn: DmlTriggerType.All);
            hesabMaliDependency.OnChanged += HesabMaliDependency_OnChanged;
            StartHesabMali();
            // واریز به حساب
            var notify = DmlTriggerType.Insert | DmlTriggerType.Delete ;
            varizBeHesabDependency = new SqlTableDependency<VarizBeHesab>(Properties.Settings.Default.CarpetCompanyConnectionString,notifyOn: notify);
            varizBeHesabDependency.OnChanged += VarizBeHesabDependency_OnChanged;
            StartVarizBeHesab();
            // پرداخت از حساب
            pardakhtAzHesabDependency = new SqlTableDependency<PardakhtAzHesab>(Properties.Settings.Default.CarpetCompanyConnectionString, notifyOn: notify);
            pardakhtAzHesabDependency.OnChanged += PardakhtAzHesabDependency_OnChanged;
            StartPardakhtAzHesab();
            // اسناد دریافتی
            asnadeDaryaftiDependency = new SqlTableDependency<AsnadeDaryafti>(Properties.Settings.Default.CarpetCompanyConnectionString, notifyOn: DmlTriggerType.All);
            asnadeDaryaftiDependency.OnChanged += AsnadeDaryaftiDependency_OnChanged;
            StartAsnadeDaryafti();
            // اسناد پرداختی
            asnadePardakhtiDependency = new SqlTableDependency<AsnadePardakhti>(Properties.Settings.Default.CarpetCompanyConnectionString, notifyOn: DmlTriggerType.All);
            asnadePardakhtiDependency.OnChanged += AsnadePardakhtiDependency_OnChanged;
            StartAsnadePardakhti();
            // سند ها
            senadDependency = new SqlTableDependency<Senad>(Properties.Settings.Default.CarpetCompanyConnectionString, notifyOn: DmlTriggerType.All);
            senadDependency.OnChanged += SenadDependency_OnChanged;
            StartSenad();
            // هزینه اداری
            hazineEdariDependency = new SqlTableDependency<HazineEdari>(Properties.Settings.Default.CarpetCompanyConnectionString, notifyOn: DmlTriggerType.All);
            hazineEdariDependency.OnChanged += HazineEdariDependency_OnChanged;
            StartHazineEdari();
            // حقوق ها
            hoghoghDependency = new SqlTableDependency<Hoghogh>(Properties.Settings.Default.CarpetCompanyConnectionString, notifyOn: DmlTriggerType.All);
            hoghoghDependency.OnChanged += Hogh_OnChanged;
            StartHoghogh();
        }

        private void HazineEdariDependency_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<HazineEdari> e)
        {
            if (HazineEdariRefresh != null)
            {
                HazineEdariRefresh(sender, e.Entity);
            }
        }

        private void Hogh_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<Hoghogh> e)
        {
            if (hoghoghRefresh != null)
            {
                hoghoghRefresh(sender, e.Entity);
            }
        }

        private void AsnadePardakhtiDependency_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<AsnadePardakhti> e)
        {
            if (asnadePardakhtiRefresh != null)
            {
                asnadePardakhtiRefresh(sender, e.Entity);
            }
        }

        private void AsnadeDaryaftiDependency_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<AsnadeDaryafti> e)
        {
            if (asnadeDaryaftiRefresh != null)
            {
                asnadeDaryaftiRefresh(sender, e.Entity);
            }
        }

        private void PardakhtAzHesabDependency_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<PardakhtAzHesab> e)
        {
            if (pardakhtRefresh != null)
            {
                pardakhtRefresh(sender, e.Entity);
            }
        }

        private void SenadDependency_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<Senad> e)
        {
            if (senadRefresh != null)
            {
                senadRefresh(sender, e.Entity);
            }
        }

        private void VarizBeHesabDependency_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<VarizBeHesab> e)
        {
            if (varizRefresh != null)
            {
                varizRefresh(sender, e.Entity);
            }
        }

        private void HesabMaliDependency_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<HesabMali> e)
        {
            if (malRefresh != null)
            {
                malRefresh(sender, e.Entity);
            }
        }

        private bool StartHesabMali()
        {
            try
            {
                hesabMaliDependency.Start();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private bool StartVarizBeHesab()
        {
            try
            {
                varizBeHesabDependency.Start();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private bool StartPardakhtAzHesab()
        {
            try
            {
                pardakhtAzHesabDependency.Start();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        private bool StartAsnadeDaryafti()
        {
            try
            {
                asnadeDaryaftiDependency.Start();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool StartAsnadePardakhti()
        {
            try
            {
                asnadePardakhtiDependency.Start();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool StartSenad()
        {

            try
            {
                senadDependency.Start();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private bool StartHazineEdari()
        {
            try
            {
                hazineEdariDependency.Start();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private bool StartHoghogh()
        {
            try
            {
                hoghoghDependency.Start();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public void Dispose()
        {
            hesabMaliDependency.Stop();
            hesabMaliDependency.Dispose();
            varizBeHesabDependency.Stop();
            varizBeHesabDependency.Dispose();
            pardakhtAzHesabDependency.Stop();
            pardakhtAzHesabDependency.Dispose();
            asnadeDaryaftiDependency.Stop();
            asnadeDaryaftiDependency.Dispose();
            asnadePardakhtiDependency.Stop();
            asnadePardakhtiDependency.Dispose();
            senadDependency.Stop();
            senadDependency.Dispose();
            hazineEdariDependency.Stop();
            hazineEdariDependency.Dispose();
            hoghoghDependency.Dispose();
            hoghoghDependency.Stop();


        }
        ~SqlTableRefresh()
        {
            Dispose();
        }
    }
}
