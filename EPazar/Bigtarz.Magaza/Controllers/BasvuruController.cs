﻿using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bigtarz.Magaza.Controllers
{
    public class BasvuruController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            _ = Sehirler();

            var Token = VKNSorgulamaToken();
            if (Token != null)
            {
                await VergiDairleri("35").ConfigureAwait(true);
                var result = VKNSorgulamaIslemi(Token, "9780516317", "35", "035252");
                
            }
            return View();
        }

        public async Task<System.Collections.Generic.List<Il>> VergiDairleri(string SeciliIl)
        {
            #region JsonVergi
            string JSONVergi = @"{
    'il':{
    '001':[ 
        {'kod':'001251','vdadi':'5 OCAK VD'},                      
        {'kod':'001114','vdadi':'ALADAĞ MAL MD.'},                 
        {'kod':'001201','vdadi':'CEYHAN VD'},
        {'kod':'001255','vdadi':'ÇUKUROVA VD'},
        {'kod':'001103','vdadi':'FEKE MAL MD.'},                   
        {'kod':'001115','vdadi':'İMAMOĞLU MAL MD.'},
        {'kod':'001205','vdadi':'KARATAŞ VD'},
        {'kod':'001105','vdadi':'KARAİSALI MAL MD.'},              
        {'kod':'001203','vdadi':'KOZAN VD'},                       
        {'kod':'001109','vdadi':'POZANTI MAL MD.'},                
        {'kod':'001110','vdadi':'SAİMBEYLİ MAL MD.'},              
        {'kod':'001253','vdadi':'SEYHAN VD'},                      
        {'kod':'001111','vdadi':'TUFANBEYLİ MAL MD.'},             
        {'kod':'001112','vdadi':'YUMURTALIK MAL MD.'},             
        {'kod':'001252','vdadi':'YÜREĞİR VD'},                     
        {'kod':'001254','vdadi':'ZİYAPAŞA VD'}
    ],
    '002':[ 
        {'kod':'002260','vdadi':'ADIYAMAN VD'},                    
        {'kod':'002101','vdadi':'BESNİ MAL MD.'},
        {'kod':'002102','vdadi':'ÇELİKHAN MAL MD.'},        
        {'kod':'002103','vdadi':'GERGER MAL MD.'},                 
        {'kod':'002104','vdadi':'GÖLBAŞI MAL MD.'},                
        {'kod':'002261','vdadi':'KAHTA VD'},                       
        {'kod':'002106','vdadi':'SAMSAT MAL MD.'},                 
        {'kod':'002107','vdadi':'SİNCİK MAL MD.'},                 
        {'kod':'002108','vdadi':'TUT MAL MD.'}
    ],
    '003':[ 
        {'kod':'003112','vdadi':'BAYAT MAL MD.'},                  
        {'kod':'003111','vdadi':'BAŞMAKÇI MAL MD.'},               
        {'kod':'003261','vdadi':'BOLVADİN VD'},
        {'kod':'003202','vdadi':'ÇAY VD'},
        {'kod':'003114','vdadi':'ÇOBANLAR MAL MD.'},
        {'kod':'003103','vdadi':'DAZKIRI MAL MD.'},                
        {'kod':'003260','vdadi':'DİNAR VD'},                       
        {'kod':'003262','vdadi':'EMİRDAĞ VD'},                     
        {'kod':'003115','vdadi':'EVCİLER MAL MD.'},                
        {'kod':'003116','vdadi':'HOCALAR MAL MD.'},
        {'kod':'003105','vdadi':'İHSANİYE MAL MD.'},
        {'kod':'003113','vdadi':'İSCEHİSAR MAL MD.'},
        {'kod':'003117','vdadi':'KIZILÖREN MAL MD.'},              
        {'kod':'003280','vdadi':'KOCATEPE VD'},                    
        {'kod':'003263','vdadi':'SANDIKLI VD'},                    
        {'kod':'003108','vdadi':'SULTANDAĞI MAL MD.'},             
        {'kod':'003107','vdadi':'SİNANPAŞA MAL MD.'},
        {'kod':'003109','vdadi':'ŞUHUT MAL MD.'},
        {'kod':'003201','vdadi':'TINAZTEPE VD'}
        ], 
        '068':[ 
        {'kod':'068201','vdadi':'AKSARAY VD'},                     
        {'kod':'068101','vdadi':'AĞAÇÖREN MAL MD.'},               
        {'kod':'068105','vdadi':'ESKİL MAL MD.'},                  
        {'kod':'068106','vdadi':'GÜLAĞAÇ MAL MD.'},                
        {'kod':'068102','vdadi':'GÜZELYURT MAL MD.'},              
        {'kod':'068103','vdadi':'ORTAKÖY MAL MD.'},                
        {'kod':'068104','vdadi':'SARIYAHŞİ MAL MD.'}
        ], 
        '005':[ 
        {'kod':'005260','vdadi':'AMASYA VD'},                      
        {'kod':'005262','vdadi':'G. HACIKÖY VD'},                  
        {'kod':'005101','vdadi':'GÖYNÜCEK MAL MD.'},               
        {'kod':'005102','vdadi':'GÜMÜŞHACIKÖY MAL MD.'},           
        {'kod':'005106','vdadi':'HAMAMÖZÜ MAL MD.'},               
        {'kod':'005261','vdadi':'MERZİFON VD'},                    
        {'kod':'005264','vdadi':'SULUOVA VD'},                     
        {'kod':'005263','vdadi':'TAŞOVA VD'}
        ], 
        '006':[ 
        {'kod':'006125','vdadi':'AKYURT MAL MD.'},                 
        {'kod':'006102','vdadi':'AYAŞ MAL MD.'},                   
        {'kod':'006103','vdadi':'BALA MAL MD.'},                   
        {'kod':'006276','vdadi':'BAŞKENT VD'},                     
        {'kod':'006209','vdadi':'BEYPAZARI VD'},                   
        {'kod':'006277','vdadi':'CUMHURİYET VD'},
        {'kod':'006106','vdadi':'ÇAMLIDERE MAL MD.'},
        {'kod':'006257','vdadi':'ÇANKAYA VD'},
        {'kod':'006211','vdadi':'ÇUBUK VD'},
        {'kod':'006274','vdadi':'DIŞKAPI VD'},                     
        {'kod':'006265','vdadi':'DOĞANBEY VD'},                    
        {'kod':'006264','vdadi':'DİKİMEVİ VD'},                    
        {'kod':'006215','vdadi':'ELMADAĞ VD'},                     
        {'kod':'006275','vdadi':'ETİMESGUT VD'},                   
        {'kod':'006127','vdadi':'EVREN MAL MD.'},
        {'kod':'006272','vdadi':'GÖLBAŞI VD'},                     
        {'kod':'006110','vdadi':'GÜDÜL MAL MD.'},                  
        {'kod':'006213','vdadi':'HAYMANA VD'},                     
        {'kod':'006268','vdadi':'HİTİT VD'},                       
        {'kod':'006112','vdadi':'KALECİK MAL MD.'},                
        {'kod':'006253','vdadi':'KAVAKLIDERE VD'},                 
        {'kod':'006279','vdadi':'KAZAN VD'},                  
        {'kod':'006124','vdadi':'KAZAN MAL MD.'},
        {'kod':'006278','vdadi':'KEÇİÖREN VD'},
        {'kod':'006258','vdadi':'KIZILBEY VD'},                    
        {'kod':'006115','vdadi':'KIZILCAHAMAM MAL MD.'},           
        {'kod':'006270','vdadi':'M.KARAGÜZEL VD'},                 
        {'kod':'006254','vdadi':'MALTEPE VD'},                     
        {'kod':'006259','vdadi':'MİTHATPAŞA VD'},                  
        {'kod':'006117','vdadi':'NALLIHAN MAL MD.'},               
        {'kod':'006271','vdadi':'OSTİM VD'},                       
        {'kod':'006205','vdadi':'POLATLI VD'},                     
        {'kod':'006262','vdadi':'SEĞMENLER VD'},                   
        {'kod':'006273','vdadi':'SİNCAN VD'},
        {'kod':'006207','vdadi':'ŞEREFLİKOÇHİSAR VD'},        
        {'kod':'006260','vdadi':'ULUS VD'},
        {'kod':'006263','vdadi':'ULUSİTE VD'},
        {'kod':'006252','vdadi':'VERASET VE HARÇ VD'},             
        {'kod':'006269','vdadi':'Y.GALİP VD'},                     
        {'kod':'006255','vdadi':'YENİMAHALLE VD'},                 
        {'kod':'006266','vdadi':'YEĞENBEY VD'},                    
        {'kod':'006261','vdadi':'YILDIRIMBEYAZIT VD'}
        ], 
        '007':[ 
        {'kod':'007101','vdadi':'AKSEKİ MAL MD.'},                 
        {'kod':'007201','vdadi':'ALANYA VD'},                      
        {'kod':'007255','vdadi':'ANTALYA KURUMLAR VD'},            
        {'kod':'007112','vdadi':'DEMRE MAL MD.'},                  
        {'kod':'007254','vdadi':'DÜDEN VD'},                       
        {'kod':'007204','vdadi':'ELMALI VD'},                      
        {'kod':'007104','vdadi':'FİNİKE MAL MD.'},                 
        {'kod':'007105','vdadi':'GAZİPAŞA MAL MD.'},               
        {'kod':'007106','vdadi':'GÜNDOĞMUŞ MAL MD.'},
        {'kod':'007113','vdadi':'İBRADI MAL MD.'},
        {'kod':'007252','vdadi':'KALEKAPI VD'},                    
        {'kod':'007107','vdadi':'KAŞ MAL MD.'},                    
        {'kod':'007205','vdadi':'KEMER VD'},                       
        {'kod':'007108','vdadi':'KORKUTELİ MAL MD.'},              
        {'kod':'007206','vdadi':'KUMLUCA VD'},                     
        {'kod':'007109','vdadi':'KUMLUCA MAL MD.'},                
        {'kod':'007203','vdadi':'MANAVGAT VD'},                    
        {'kod':'007253','vdadi':'MURATPAŞA VD'},                   
        {'kod':'007202','vdadi':'SERİK VD'},                       
        {'kod':'007251','vdadi':'ÜÇKAPILAR VD'}
        ], 
        '075':[ 
        {'kod':'075201','vdadi':'ARDAHAN VD'},
        {'kod':'075101','vdadi':'ÇILDIR MAL MD.'},
        {'kod':'075102','vdadi':'DAMAL MAL MD.'},                  
        {'kod':'075103','vdadi':'GÖLE MAL MD.'},                   
        {'kod':'075104','vdadi':'HANAK MAL MD.'},                  
        {'kod':'075105','vdadi':'POSOF MAL MD.'}
        ], 
        '008':[ 
        {'kod':'008101','vdadi':'ARDANUÇ MAL MD.'},                
        {'kod':'008102','vdadi':'ARHAVİ MAL MD.'},                 
        {'kod':'008260','vdadi':'ARTVİN VD'},                      
        {'kod':'008103','vdadi':'BORÇKA MAL MD.'},                 
        {'kod':'008261','vdadi':'HOPA VD'},                        
        {'kod':'008107','vdadi':'MURGUL MAL MD.'},
        {'kod':'008105','vdadi':'ŞAVŞAT MAL MD.'},        
        {'kod':'008106','vdadi':'YUSUFELİ MAL MD.'}
        ], 
        '009':[ 
        {'kod':'009101','vdadi':'BOZDOĞAN MAL MD.'},               
        {'kod':'009112','vdadi':'BUHARKENT MAL MD.'},
        {'kod':'009262','vdadi':'ÇİNE VD'},        
        {'kod':'009281','vdadi':'DİDİM VD'},                       
        {'kod':'009201','vdadi':'EFELER VD'},                      
        {'kod':'009263','vdadi':'GERMENCİK VD'},                   
        {'kod':'009280','vdadi':'GÜZELHİSAR VD'},
        {'kod':'009113','vdadi':'İNCİRLİOVA MAL MD.'},
        {'kod':'009104','vdadi':'KARACASU MAL MD.'},               
        {'kod':'009114','vdadi':'KARPUZLU MAL MD.'},               
        {'kod':'009105','vdadi':'KOÇARLI MAL MD.'},
        {'kod':'009115','vdadi':'KÖŞK MAL MD.'},        
        {'kod':'009107','vdadi':'KUYUCAK MAL MD.'},                
        {'kod':'009265','vdadi':'KUŞADASI VD'},
        {'kod':'009260','vdadi':'NAZİLLİ VD'},                     
        {'kod':'009110','vdadi':'SULTANHİSAR MAL MD.'},            
        {'kod':'009261','vdadi':'SÖKE VD'},                        
        {'kod':'009111','vdadi':'YENİPAZAR MAL MD.'}
        ], 
        '004':[ 
        {'kod':'004260','vdadi':'AĞRI VD'},                        
        {'kod':'004261','vdadi':'DOĞUBEYAZIT VD'},                 
        {'kod':'004101','vdadi':'DİYADİN MAL MD.'},                
        {'kod':'004103','vdadi':'ELEŞKİRT MAL MD.'},               
        {'kod':'004104','vdadi':'HAMUR MAL MD.'},                  
        {'kod':'004105','vdadi':'PATNOS MAL MD.'},                 
        {'kod':'004106','vdadi':'TAŞLIÇAY MAL MD.'},               
        {'kod':'004107','vdadi':'TUTAK MAL MD.'}
        ], 
        '010':[ 
        {'kod':'010260','vdadi':'AYVALIK VD'},                     
        {'kod':'010102','vdadi':'BALYA MAL MD.'},                  
        {'kod':'010261','vdadi':'BANDIRMA VD'},
        {'kod':'010267','vdadi':'BİGADİÇ VD'},        
        {'kod':'010262','vdadi':'BURHANİYE VD'},
        {'kod':'010269','vdadi':'DURSUNBEY VD'},                   
        {'kod':'010263','vdadi':'EDREMİT VD'},                     
        {'kod':'010266','vdadi':'ERDEK VD'},                       
        {'kod':'010118','vdadi':'GÖMEÇ MAL MD.'},                  
        {'kod':'010264','vdadi':'GÖNEN VD'},                       
        {'kod':'010110','vdadi':'HAVRAN MAL MD.'},
        {'kod':'010111','vdadi':'İVRİNDİ MAL MD.'},        
        {'kod':'010201','vdadi':'KARESİ VD'},                      
        {'kod':'010112','vdadi':'KEPSUT MAL MD.'},                 
        {'kod':'010280','vdadi':'KURTDERELİ VD'},                  
        {'kod':'010113','vdadi':'MANYAS MAL MD.'},                 
        {'kod':'010117','vdadi':'MARMARA MAL MD.'},                
        {'kod':'010114','vdadi':'SAVAŞTEPE MAL MD.'},              
        {'kod':'010268','vdadi':'SINDIRGI VD'},                    
        {'kod':'010265','vdadi':'SUSURLUK VD'}
        ], 
        '074':[ 
        {'kod':'074101','vdadi':'AMASRA MAL MD.'},                 
        {'kod':'074260','vdadi':'BARTIN VD'},                      
        {'kod':'074102','vdadi':'KURUCAŞİLE MAL MD.'},             
        {'kod':'074103','vdadi':'ULUS MAL MD.'}
        ], 
        '072':[ 
        {'kod':'072260','vdadi':'BATMAN VD'},                      
        {'kod':'072101','vdadi':'BEŞİRİ MAL MD.'},                 
        {'kod':'072102','vdadi':'GERCÜŞ MAL MD.'},                 
        {'kod':'072103','vdadi':'HASANKEYF MAL MD.'},              
        {'kod':'072104','vdadi':'KOZLUK MAL MD.'},                 
        {'kod':'072105','vdadi':'SASON MAL MD.'}
        ], 
        '069':[ 
        {'kod':'069101','vdadi':'AYDINTEPE MAL MD.'},              
        {'kod':'069201','vdadi':'BAYBURT VD'},                     
        {'kod':'069102','vdadi':'DEMİRÖZÜ MAL MD.'}
        ], 
        
        '014':[ 
        {'kod':'014260','vdadi':'BOLU VD'},                        
        {'kod':'014113','vdadi':'DÖRTDİVAN MAL MD.'},              
        {'kod':'014262','vdadi':'GEREDE VD'},                      
        {'kod':'014104','vdadi':'GÖYNÜK MAL MD.'},                 
        {'kod':'014105','vdadi':'KIBRISCIK MAL MD.'},              
        {'kod':'014106','vdadi':'MENGEN MAL MD.'},                 
        {'kod':'014107','vdadi':'MUDURNU MAL MD.'},                
        {'kod':'014108','vdadi':'SEBEN MAL MD.'},                  
        {'kod':'014114','vdadi':'YENİÇAĞA MAL MD.'}
        ], 
        '015':[
        {'kod':'015101','vdadi':'AĞLASUN MAL MD.'},        
        {'kod':'015108','vdadi':'ALTINYAYLA MAL MD.'},
        {'kod':'015261','vdadi':'BUCAK VD'},                       
        {'kod':'015260','vdadi':'BURDUR VD'},
        {'kod':'015109','vdadi':'ÇAVDIR MAL MD.'},
        {'kod':'015110','vdadi':'ÇELTİKÇİ MAL MD.'},        
        {'kod':'015103','vdadi':'GÖLHİSAR MAL MD.'},               
        {'kod':'015106','vdadi':'KARAMANLI MAL MD.'},              
        {'kod':'015107','vdadi':'KEMER MAL MD.'},                  
        {'kod':'015104','vdadi':'TEFENNİ MAL MD.'},                
        {'kod':'015105','vdadi':'YEŞİLOVA MAL MD.'}
        ], 
        '016':[ 
        {'kod':'016112','vdadi':'BÜYÜKORHAN MAL MD.'},
        {'kod':'016253','vdadi':'ÇEKİRGE VD'},
        {'kod':'016258','vdadi':'ERTUĞRULGAZİ VD'},                
        {'kod':'016201','vdadi':'GEMLİK VD'},                      
        {'kod':'016259','vdadi':'GÖKDERE VD'},                     
        {'kod':'016111','vdadi':'HARMANCIK MAL MD.'},
        {'kod':'016202','vdadi':'İNEGÖL VD'},
        {'kod':'016207','vdadi':'İZNİK VD'},        
        {'kod':'016203','vdadi':'KARACABEY VD'},                   
        {'kod':'016105','vdadi':'KELES MAL MD.'},                  
        {'kod':'016205','vdadi':'MUDANYA VD'},                     
        {'kod':'016204','vdadi':'MUSTAFAKEMALPAŞA VD'},            
        {'kod':'016257','vdadi':'NİLÜFER VD'},                     
        {'kod':'016108','vdadi':'ORHANELİ MAL MD.'},               
        {'kod':'016206','vdadi':'ORHANGAZİ VD'},                   
        {'kod':'016251','vdadi':'OSMANGAZİ VD'},                   
        {'kod':'016254','vdadi':'SETBAŞI VD'},                     
        {'kod':'016255','vdadi':'ULUDAĞ VD'},                      
        {'kod':'016208','vdadi':'YENİŞEHİR VD'},                   
        {'kod':'016256','vdadi':'YEŞİL VD'},                       
        {'kod':'016252','vdadi':'YILDIRIM VD'}
        ], 
        '011':[
        {'kod':'011260','vdadi':'BİLECİK VD'},        
        {'kod':'011261','vdadi':'BOZÜYÜK VD'},
        {'kod':'011102','vdadi':'GÖLPAZARI MAL MD.'},
        {'kod':'011107','vdadi':'İNHİSAR MAL MD.'},        
        {'kod':'011103','vdadi':'OSMANELİ MAL MD.'},               
        {'kod':'011104','vdadi':'PAZARYERİ MAL MD.'},              
        {'kod':'011105','vdadi':'SÖĞÜT MAL MD.'},                  
        {'kod':'011106','vdadi':'YENİPAZAR MAL MD.'}
        ], 
        '012':[ 
        {'kod':'012105','vdadi':'ADAKLI MAL MD.'},                 
        {'kod':'012260','vdadi':'BİNGÖL VD'},                      
        {'kod':'012101','vdadi':'GENÇ MAL MD.'},                   
        {'kod':'012102','vdadi':'KARLIOVA MAL MD.'},               
        {'kod':'012103','vdadi':'KIĞI MAL MD.'},                   
        {'kod':'012104','vdadi':'SOLHAN MAL MD.'},                 
        {'kod':'012106','vdadi':'YAYLADERE MAL MD.'},              
        {'kod':'012107','vdadi':'YEDİSU MAL MD.'}
        ], 
        '013':[ 
        {'kod':'013101','vdadi':'ADİLCEVAZ MAL MD.'},              
        {'kod':'013102','vdadi':'AHLAT MAL MD.'},                  
        {'kod':'013260','vdadi':'BİTLİS VD'},                      
        {'kod':'013106','vdadi':'GÜROYMAK MAL MD.'},               
        {'kod':'013103','vdadi':'HİZAN MAL MD.'},                  
        {'kod':'013104','vdadi':'MUTKİ MAL MD.'},                  
        {'kod':'013261','vdadi':'TATVAN VD'}
        ], 
        '020':[ 
        {'kod':'020261','vdadi':'ACIPAYAM VD'},                    
        {'kod':'020115','vdadi':'AKKÖY MAL MD.'},                  
        {'kod':'020111','vdadi':'BABADAĞ MAL MD.'},                
        {'kod':'020116','vdadi':'BAKLAN MAL MD.'},                 
        {'kod':'020112','vdadi':'BEKİLLİ MAL MD.'},                
        {'kod':'020117','vdadi':'BEYAĞAÇ MAL MD.'},                
        {'kod':'020118','vdadi':'BOZKURT MAL MD.'},                
        {'kod':'020263','vdadi':'BULDAN VD'},
        {'kod':'020264','vdadi':'ÇAL VD'},
        {'kod':'020104','vdadi':'ÇAMELİ MAL MD.'},
        {'kod':'020105','vdadi':'ÇARDAK MAL MD.'},
        {'kod':'020202','vdadi':'ÇINAR VD'},
        {'kod':'020265','vdadi':'ÇİVRİL VD'},        
        {'kod':'020203','vdadi':'GÖKPINAR VD'},                    
        {'kod':'020107','vdadi':'GÜNEY MAL MD.'},                  
        {'kod':'020113','vdadi':'HONAZ MAL MD.'},                  
        {'kod':'020108','vdadi':'KALE MAL MD.'},                   
        {'kod':'020280','vdadi':'PAMUKKALE VD'},                   
        {'kod':'020260','vdadi':'SARAYKÖY VD'},                    
        {'kod':'020201','vdadi':'SARAYLAR VD'},                    
        {'kod':'020114','vdadi':'SERİNHİSAR MAL MD.'},             
        {'kod':'020262','vdadi':'TAVAS VD'}
        ], 
        '081':[ 
        {'kod':'081261','vdadi':'AKÇAKOCA VD'},                    
        {'kod':'081102','vdadi':'CUMAYERİ MAL MD.'},
        {'kod':'081103','vdadi':'ÇİLİMLİ MAL MD.'},        
        {'kod':'081260','vdadi':'DÜZCE VD'},                       
        {'kod':'081104','vdadi':'GÖLYAKA MAL MD.'},                
        {'kod':'081105','vdadi':'GÜMÜŞOVA MAL MD.'},               
        {'kod':'081106','vdadi':'KAYNAŞLI MAL MD.'},               
        {'kod':'081107','vdadi':'YIĞILCA MAL MD.'}
        ], 
        '021':[ 
        {'kod':'021101','vdadi':'BİSMİL MAL MD.'},                 
        {'kod':'021282','vdadi':'C. SITKI TARANCI VD'},
        {'kod':'021102','vdadi':'ÇERMİK MAL MD.'},
        {'kod':'021103','vdadi':'ÇINAR MAL MD.'},
        {'kod':'021104','vdadi':'ÇÜNGÜŞ MAL MD.'},        
        {'kod':'021105','vdadi':'DİCLE MAL MD.'},
        {'kod':'021112','vdadi':'EĞİL MAL MD.'},        
        {'kod':'021106','vdadi':'ERGANİ MAL MD.'},
        {'kod':'021251','vdadi':'GÖKALP VD'},                      
        {'kod':'021107','vdadi':'HANİ MAL MD.'},                   
        {'kod':'021108','vdadi':'HAZRO MAL MD.'},                  
        {'kod':'021113','vdadi':'KOCAKÖY MAL MD.'},                
        {'kod':'021109','vdadi':'KULP MAL MD.'},                   
        {'kod':'021110','vdadi':'LİCE MAL MD.'},
        {'kod':'021111','vdadi':'SİLVAN MAL MD.'},
        {'kod':'021281','vdadi':'SÜLEYMANNAZİF VD'}
        ], 
        '022':[ 
        {'kod':'022201','vdadi':'ARDA VD'},                        
        {'kod':'022101','vdadi':'ENEZ MAL MD.'},                   
        {'kod':'022263','vdadi':'HAVSA VD'},
        {'kod':'022264','vdadi':'İPSALA VD'},        
        {'kod':'022261','vdadi':'KEŞAN VD'},                       
        {'kod':'022260','vdadi':'KIRKPINAR VD'},                   
        {'kod':'022105','vdadi':'LALAPAŞA MAL MD.'},               
        {'kod':'022106','vdadi':'MERİÇ MAL MD.'},                  
        {'kod':'022108','vdadi':'SÜLOĞLU MAL MD.'},                
        {'kod':'022262','vdadi':'UZUNKÖPRÜ VD'}
        ], 
        '023':[
        {'kod':'023101','vdadi':'AĞIN MAL MD.'},
        {'kod':'023110','vdadi':'ALACAKAYA MAL MD.'},              
        {'kod':'023108','vdadi':'ARICAK MAL MD.'},
        {'kod':'023102','vdadi':'BASKİL MAL MD.'},                 
        {'kod':'023201','vdadi':'HARPUT VD'},                      
        {'kod':'023280','vdadi':'HAZAR VD'},                       
        {'kod':'023103','vdadi':'KARAKOÇAN MAL MD.'},              
        {'kod':'023104','vdadi':'KEBAN MAL MD.'},                  
        {'kod':'023109','vdadi':'KOVANCILAR MAL MD.'},             
        {'kod':'023105','vdadi':'MADEN MAL MD.'},                  
        {'kod':'023106','vdadi':'PALU MAL MD.'},                   
        {'kod':'023107','vdadi':'SİVRİCE MAL MD.'}
        ], 
        '025':[ 
        {'kod':'025251','vdadi':'AZİZİYE VD'},                     
        {'kod':'025101','vdadi':'AŞKALE MAL MD.'},
        {'kod':'025102','vdadi':'ÇAT MAL MD.'},
        {'kod':'025103','vdadi':'HINIS MAL MD.'},                  
        {'kod':'025104','vdadi':'HOROSAN MAL MD.'},                
        {'kod':'025117','vdadi':'ILICA MAL MD.'},
        {'kod':'025105','vdadi':'İSPİR MAL MD.'},
        {'kod':'025114','vdadi':'KARAÇOBAN MAL MD.'},        
        {'kod':'025106','vdadi':'KARAYAZI MAL MD.'},
        {'kod':'025280','vdadi':'KAZIMKARABEKİR VD'},              
        {'kod':'025118','vdadi':'KÖPRÜKÖY MAL MD.'},               
        {'kod':'025107','vdadi':'NARMAN MAL MD.'},                 
        {'kod':'025108','vdadi':'OLTU MAL MD.'},                   
        {'kod':'025109','vdadi':'OLUR MAL MD.'},                   
        {'kod':'025110','vdadi':'PASİNLER MAL MD.'},               
        {'kod':'025116','vdadi':'PAZARYOLU MAL MD.'},
        {'kod':'025111','vdadi':'ŞENKAYA MAL MD.'},        
        {'kod':'025112','vdadi':'TEKMAN MAL MD.'},                 
        {'kod':'025113','vdadi':'TORTUM MAL MD.'},                 
        {'kod':'025115','vdadi':'UZUNDERE MAL MD.'}
        ], 
        '024':[
        {'kod':'024101','vdadi':'ÇAYIRLI MAL MD.'},
        {'kod':'024260','vdadi':'FEVZİPAŞA VD'},
        {'kod':'024102','vdadi':'İLİÇ MAL MD.'},        
        {'kod':'024103','vdadi':'KEMAH MAL MD.'},                  
        {'kod':'024104','vdadi':'KEMALİYE MAL MD.'},               
        {'kod':'024108','vdadi':'OTLUKBELİ MAL MD.'},              
        {'kod':'024105','vdadi':'REFAHİYE MAL MD.'},
        {'kod':'024106','vdadi':'TERCAN MAL MD.'},
        {'kod':'024107','vdadi':'ÜZÜMLÜ MAL MD.'}
        ], 
        '026':[ 
        {'kod':'026253','vdadi':'2 EYLÜL VD'},                     
        {'kod':'026107','vdadi':'ALPU MAL MD.'},                   
        {'kod':'026254','vdadi':'BATTALGAZİ VD'},                  
        {'kod':'026108','vdadi':'BEYLİKOVA MAL MD.'},
        {'kod':'026201','vdadi':'ÇİFTELER VD'},
        {'kod':'026110','vdadi':'GÜNYÜZÜ MAL MD.'},                
        {'kod':'026111','vdadi':'HAN MAL MD.'},
        {'kod':'026109','vdadi':'İNÖNÜ MAL MD.'},        
        {'kod':'026102','vdadi':'MAHMUDİYE MAL MD.'},              
        {'kod':'026112','vdadi':'MİHALGAZİ MAL MD.'},              
        {'kod':'026103','vdadi':'MİHALIÇÇIK MAL MD.'},             
        {'kod':'026104','vdadi':'SARICAKAYA MAL MD.'},             
        {'kod':'026105','vdadi':'SEYİTGAZİ MAL MD.'},              
        {'kod':'026202','vdadi':'SİVRİHİSAR VD'},                  
        {'kod':'026106','vdadi':'SİVRİHİSAR MAL MD.'},             
        {'kod':'026255','vdadi':'TAŞBAŞI VD'},                     
        {'kod':'026252','vdadi':'YUNUSEMRE VD'}
        ], 
        '027':[ 
        {'kod':'027101','vdadi':'ARABAN MAL MD.'},                 
        {'kod':'027254','vdadi':'GAZİKENT VD'},
        {'kod':'027203','vdadi':'İSLAHİYE VD'},
        {'kod':'027107','vdadi':'KARKAMIŞ MAL MD.'},               
        {'kod':'027255','vdadi':'KOZANLI VD'},
        {'kod':'027202','vdadi':'NİZİP VD'},
        {'kod':'027108','vdadi':'NURDAĞI MAL MD.'},
        {'kod':'027105','vdadi':'OĞUZELİ MAL MD.'},                
        {'kod':'027251','vdadi':'SUBURCU VD'},
        {'kod':'027253','vdadi':'ŞAHİNBEY VD'},
        {'kod':'027252','vdadi':'ŞEHİTKAMİL VD'},        
        {'kod':'027106','vdadi':'YAVUZELİ MAL MD.'}
        ], 
        '029':[ 
        {'kod':'029260','vdadi':'GÜMÜŞHANE VD'},                   
        {'kod':'029102','vdadi':'KELKİT MAL MD.'},                 
        {'kod':'029107','vdadi':'KÖSE MAL MD.'},                   
        {'kod':'029108','vdadi':'KÜRTÜN MAL MD.'},
        {'kod':'029103','vdadi':'ŞİRAN MAL MD.'},        
        {'kod':'029104','vdadi':'TORUL MAL MD.'}
        ], 
        '028':[ 
        {'kod':'028101','vdadi':'ALUCRA MAL MD.'},                 
        {'kod':'028261','vdadi':'BULANCAK VD'},
        {'kod':'028114','vdadi':'ÇAMOLUK MAL MD.'},
        {'kod':'028112','vdadi':'ÇANAKÇI MAL MD.'},
        {'kod':'028103','vdadi':'DERELİ MAL MD.'},                 
        {'kod':'028115','vdadi':'DOĞANKENT MAL MD.'},              
        {'kod':'028104','vdadi':'ESPİYE MAL MD.'},                 
        {'kod':'028105','vdadi':'EYNESİL MAL MD.'},
        {'kod':'028260','vdadi':'GİRESUN VD'},
        {'kod':'028106','vdadi':'GÖRELE MAL MD.'},                 
        {'kod':'028113','vdadi':'GÜCE MAL MD.'},
        {'kod':'028107','vdadi':'KEŞAP MAL MD.'},                  
        {'kod':'028110','vdadi':'PİRAZİZ MAL MD.'},
        {'kod':'028108','vdadi':'ŞEBİNKARAHİSAR MAL MD.'},        
        {'kod':'028109','vdadi':'TİREBOLU MAL MD.'},               
        {'kod':'028111','vdadi':'YAĞLIDERE MAL MD.'}
        ], 
        '030':[
        {'kod':'030102','vdadi':'ÇUKURCA MAL MD.'},
        {'kod':'030260','vdadi':'HAKKARİ VD'},
        {'kod':'030103','vdadi':'ŞEMDİNLİ MAL MD.'},        
        {'kod':'030261','vdadi':'YÜKSEKOVA VD.'}
        ], 
        '031':[ 
        {'kod':'031201','vdadi':'23 TEMMUZ VD'},                   
        {'kod':'031281','vdadi':'AKDENİZ VD'},                     
        {'kod':'031101','vdadi':'ALTINÖZÜ MAL MD.'},               
        {'kod':'031203','vdadi':'ANTAKYA VD'},                     
        {'kod':'031290','vdadi':'ASIM GÜNDÜZ VD'},                 
        {'kod':'031110','vdadi':'BELEN MAL MD.'},                  
        {'kod':'031260','vdadi':'DÖRTYOL VD'},                     
        {'kod':'031109','vdadi':'ERZİN MAL MD.'},                  
        {'kod':'031103','vdadi':'HASSA MAL MD.'},                  
        {'kod':'031261','vdadi':'KIRIKHAN VD'},                    
        {'kod':'031111','vdadi':'KUMLU MAL MD.'},                  
        {'kod':'031262','vdadi':'REYHANLI VD'},                    
        {'kod':'031202','vdadi':'SAHİL VD'},                       
        {'kod':'031263','vdadi':'SAMANDAĞ VD'},
        {'kod':'031280','vdadi':'ŞÜKRÜKANATLI VD'},        
        {'kod':'031108','vdadi':'YAYLADAĞ MAL MD.'}
        ], 
        '032':[ 
        {'kod':'032110','vdadi':'AKSU MAL MD.'},                   
        {'kod':'032101','vdadi':'ATABEY MAL MD.'},                 
        {'kod':'032201','vdadi':'DAVRAZ VD'},                      
        {'kod':'032261','vdadi':'EĞİRDİR VD'},                     
        {'kod':'032103','vdadi':'GELENDOST MAL MD.'},              
        {'kod':'032111','vdadi':'GÖNEN MAL MD.'},                  
        {'kod':'032260','vdadi':'KAYMAKKAPI VD'},                  
        {'kod':'032104','vdadi':'KEÇİBORLU MAL MD.'},              
        {'kod':'032105','vdadi':'SENİRKENT MAL MD.'},              
        {'kod':'032106','vdadi':'SÜTÇÜLER MAL MD.'},
        {'kod':'032107','vdadi':'ŞARKİKARAAĞAÇ MAL MD.'},        
        {'kod':'032108','vdadi':'ULUBORLU MAL MD.'},               
        {'kod':'032262','vdadi':'YALVAÇ VD'},                      
        {'kod':'032112','vdadi':'YENİŞARBADEMLİ M MAL MD.'}
        ], 
        '076':[ 
        {'kod':'076101','vdadi':'ARALIK MAL MD.'},                 
        {'kod':'076201','vdadi':'IĞDIR VD'},                       
        {'kod':'076102','vdadi':'KARAKOYUNLU MAL MD.'},            
        {'kod':'076103','vdadi':'TUZLUCA MAL MD.'}
        ], 
        '046':[ 
        {'kod':'046261','vdadi':'AFŞİN VD'},                       
        {'kod':'046280','vdadi':'AKSU VD'},                        
        {'kod':'046102','vdadi':'ANDIRIN MAL MD.'},                
        {'kod':'046201','vdadi':'ASLANBEY VD'},
        {'kod':'046107','vdadi':'ÇAĞLIYANCERİT MAL MD.'},        
        {'kod':'046108','vdadi':'EKİNÖZÜ MAL MD.'},                
        {'kod':'046260','vdadi':'ELBİSTAN VD'},                    
        {'kod':'046104','vdadi':'GÖKSUN MAL MD.'},                 
        {'kod':'046109','vdadi':'NURHAK MAL MD.'},                 
        {'kod':'046262','vdadi':'PAZARCIK VD'},                    
        {'kod':'046106','vdadi':'TÜRKOĞLU MAL MD.'}
        ], 
        '078':[ 
        {'kod':'078101','vdadi':'EFLANİ MAL MD.'},                 
        {'kod':'078102','vdadi':'ESKİPAZAR MAL MD.'},              
        {'kod':'078201','vdadi':'KARABÜK VD'},                     
        {'kod':'078103','vdadi':'OVACIK MAL MD.'},                 
        {'kod':'078260','vdadi':'SAFRANBOLU VD'},                  
        {'kod':'078105','vdadi':'YENİCE MAL MD.'}
        ], 
        '070':[ 
        {'kod':'070101','vdadi':'AYRANCI MAL MD.'},                
        {'kod':'070104','vdadi':'BAŞYAYLA MAL MD.'},               
        {'kod':'070102','vdadi':'ERMENEK MAL MD.'},                
        {'kod':'070103','vdadi':'K.KARABEKİR MAL MD.'},            
        {'kod':'070201','vdadi':'KARAMAN VD'},                     
        {'kod':'070105','vdadi':'SARIVELİLER MAL MD.'}
        ], 
        '036':[ 
        {'kod':'036115','vdadi':'AKYAKA MAL MD.'},                 
        {'kod':'036103','vdadi':'ARPAÇAY MAL MD.'},                
        {'kod':'036105','vdadi':'DİGOR MAL MD.'},
        {'kod':'036109','vdadi':'KAĞIZMAN MAL MD.'},
        {'kod':'036260','vdadi':'KARS VD'},
        {'kod':'036111','vdadi':'SARIKAMIŞ MAL MD.'},              
        {'kod':'036112','vdadi':'SELİM MAL MD.'},                  
        {'kod':'036113','vdadi':'SUSUZ MAL MD.'}
        ], 
        '037':[ 
        {'kod':'037112','vdadi':'ABANA MAL MD.'},
        {'kod':'037116','vdadi':'AĞLI MAL MD.'},
        {'kod':'037101','vdadi':'ARAÇ MAL MD.'},                   
        {'kod':'037102','vdadi':'AZDAVAY MAL MD.'},
        {'kod':'037103','vdadi':'BOZKURT MAL MD.'},                
        {'kod':'037104','vdadi':'CİDE MAL MD.'},
        {'kod':'037105','vdadi':'ÇATALZEYTİN MAL MD.'},
        {'kod':'037106','vdadi':'DADAY MAL MD.'},                  
        {'kod':'037107','vdadi':'DEVREKANİ MAL MD.'},              
        {'kod':'037117','vdadi':'DOĞANYURT MAL MD.'},              
        {'kod':'037118','vdadi':'HANÖNÜ MAL MD.'},
        {'kod':'037113','vdadi':'İHSANGAZİ MAL MD.'},
        {'kod':'037108','vdadi':'İNEBOLU MAL MD.'},
        {'kod':'037260','vdadi':'KASTAMONU VD'},                   
        {'kod':'037109','vdadi':'KÜRE MAL MD.'},                   
        {'kod':'037114','vdadi':'PINARBAŞI MAL MD.'},              
        {'kod':'037119','vdadi':'SEYDİLER MAL MD.'},
        {'kod':'037115','vdadi':'ŞENPAZAR MAL MD.'},        
        {'kod':'037262','vdadi':'TAŞKÖPRÜ VD'},                    
        {'kod':'037261','vdadi':'TOSYA VD'}
        ], 
        '038':[ 
        {'kod':'038111','vdadi':'AKKIŞLA MAL MD.'},                
        {'kod':'038203','vdadi':'BÜNYAN VD'},                      
        {'kod':'038201','vdadi':'DEVELİ VD'},                      
        {'kod':'038252','vdadi':'ERCİYES VD'},                     
        {'kod':'038103','vdadi':'FELAHİYE MAL MD.'},               
        {'kod':'038254','vdadi':'GEVHER NESİBE VD'},               
        {'kod':'038113','vdadi':'HACILAR MAL MD.'},
        {'kod':'038104','vdadi':'İNCESU MAL MD.'},        
        {'kod':'038253','vdadi':'KALEÖNÜ VD'},                     
        {'kod':'038251','vdadi':'MİMARSİNAN VD'},
        {'kod':'038114','vdadi':'ÖZVATAN MAL MD.'},
        {'kod':'038202','vdadi':'PINARBAŞI VD'},                   
        {'kod':'038106','vdadi':'SARIOĞLAN MAL MD.'},              
        {'kod':'038107','vdadi':'SARIZ MAL MD.'},
        {'kod':'038108','vdadi':'TOMARZA MAL MD.'},                
        {'kod':'038109','vdadi':'YAHYALI MAL MD.'},                
        {'kod':'038110','vdadi':'YEŞİLHİSAR MAL MD.'}
        ], 
        '071':[ 
        {'kod':'071105','vdadi':'BALIŞEYH MAL MD.'},
        {'kod':'071106','vdadi':'ÇELEBİ MAL MD.'},        
        {'kod':'071101','vdadi':'DELİCE MAL MD.'},                 
        {'kod':'071201','vdadi':'IRMAK VD'},                       
        {'kod':'071202','vdadi':'KALETEPE VD'},                    
        {'kod':'071107','vdadi':'KARAKEÇİLİ MAL MD.'},             
        {'kod':'071102','vdadi':'KESKİN MAL MD.'},                 
        {'kod':'071103','vdadi':'SULAKYURT MAL MD.'}
        ], 
        '039':[ 
        {'kod':'039262','vdadi':'BABAESKİ VD'},                    
        {'kod':'039102','vdadi':'DEMİRKÖY MAL MD.'},               
        {'kod':'039260','vdadi':'KIRKLARELİ VD'},                  
        {'kod':'039103','vdadi':'KOFCAZ MAL MD.'},                 
        {'kod':'039261','vdadi':'LÜLEBURGAZ VD'},                  
        {'kod':'039105','vdadi':'PEHLİVANKÖY MAL MD.'},            
        {'kod':'039106','vdadi':'PINARHİSAR MAL MD.'},             
        {'kod':'039107','vdadi':'VİZE MAL MD.'}
        ], 
        '040':[
        {'kod':'040105','vdadi':'AKÇAKENT MAL MD.'},
        {'kod':'040104','vdadi':'AKPINAR MAL MD.'},
        {'kod':'040106','vdadi':'BOZTEPE MAL MD.'},
        {'kod':'040101','vdadi':'ÇİÇEKDAĞI MAL MD.'},        
        {'kod':'040261','vdadi':'KAMAN VD'},                       
        {'kod':'040260','vdadi':'KIRŞEHİR VD'},                    
        {'kod':'040103','vdadi':'MUCUR MAL MD.'}
        ], 
        '041':[ 
        {'kod':'041290','vdadi':'ACISU VD'},                       
        {'kod':'041253','vdadi':'ALEMDAR VD'},                     
        {'kod':'041207','vdadi':'DERİNCE VD'},                     
        {'kod':'041204','vdadi':'GÖLCÜK VD'},
        {'kod':'041203','vdadi':'İLYASBEY VD'},        
        {'kod':'041103','vdadi':'KANDIRA MAL MD.'},                
        {'kod':'041205','vdadi':'KARAMÜRSEL VD'},                  
        {'kod':'041206','vdadi':'KÖRFEZ VD'},                      
        {'kod':'041252','vdadi':'TEPECİK VD'},                     
        {'kod':'041202','vdadi':'ULUÇINAR VD'}
        ], 
        '042':[ 
        {'kod':'042124','vdadi':'AHIRLI MAL MD.'},                 
        {'kod':'042118','vdadi':'AKÖREN MAL MD.'},                 
        {'kod':'042201','vdadi':'AKŞEHİR VD'},                     
        {'kod':'042254','vdadi':'ALAADDİN VD'},                    
        {'kod':'042119','vdadi':'ALTINEKİN MAL MD.'},              
        {'kod':'042204','vdadi':'BEYŞEHİR VD'},                    
        {'kod':'042103','vdadi':'BOZKIR MAL MD.'},                 
        {'kod':'042205','vdadi':'CİHANBEYLİ VD'},
        {'kod':'042125','vdadi':'ÇELTİK MAL MD.'},
        {'kod':'042206','vdadi':'ÇUMRA VD'},
        {'kod':'042126','vdadi':'DERBENT MAL MD.'},                
        {'kod':'042121','vdadi':'DEREBUCAK MAL MD.'},              
        {'kod':'042106','vdadi':'DOĞANHİSAR MAL MD.'},             
        {'kod':'042127','vdadi':'EMİRGAZİ MAL MD.'},               
        {'kod':'042202','vdadi':'EREĞLİ VD'},                      
        {'kod':'042128','vdadi':'GÜNEYSINIR MAL MD.'},             
        {'kod':'042109','vdadi':'HADİM MAL MD.'},                  
        {'kod':'042129','vdadi':'HALKAPINAR MAL MD.'},             
        {'kod':'042122','vdadi':'HÜYÜK MAL MD.'},                  
        {'kod':'042208','vdadi':'ILGIN VD'},                       
        {'kod':'042111','vdadi':'KADINHAN MAL MD.'},               
        {'kod':'042113','vdadi':'KARAPINAR MAL MD.'},              
        {'kod':'042209','vdadi':'KULU VD'},                        
        {'kod':'042253','vdadi':'MERAM VD'},                       
        {'kod':'042252','vdadi':'MEVLANA VD'},                     
        {'kod':'042115','vdadi':'SARAYÖNÜ MAL MD.'},               
        {'kod':'042251','vdadi':'SELÇUK VD'},                      
        {'kod':'042207','vdadi':'SEYDİŞEHİR VD'},                  
        {'kod':'042123','vdadi':'TAŞKENT MAL MD.'},                
        {'kod':'042130','vdadi':'TUZLUKCU MAL MD.'},               
        {'kod':'042131','vdadi':'YALIHÜYÜK MAL MD.'},              
        {'kod':'042117','vdadi':'YUNAK MAL MD.'}
        ], 
        '043':[ 
        {'kod':'043201','vdadi':'30 AĞUSTOS VD'},                  
        {'kod':'043101','vdadi':'ALTINTAŞ MAL MD.'},               
        {'kod':'043107','vdadi':'ASLANAPA MAL MD.'},
        {'kod':'043111','vdadi':'ÇAVDARHİSAR MAL MD.'},
        {'kod':'043280','vdadi':'ÇİNİLİ VD'},
        {'kod':'043102','vdadi':'DOMANİÇ MAL MD.'},                
        {'kod':'043108','vdadi':'DUMLUPINAR MAL MD.'},             
        {'kod':'043263','vdadi':'EMET VD'},                        
        {'kod':'043260','vdadi':'GEDİZ VD'},                       
        {'kod':'043109','vdadi':'HİSARCIK MAL MD.'},               
        {'kod':'043112','vdadi':'PAZARLAR MAL MD.'},               
        {'kod':'043261','vdadi':'SİMAV VD'},
        {'kod':'043110','vdadi':'ŞAPHANE MAL MD.'},        
        {'kod':'043262','vdadi':'TAVŞANLI VD'}
        ], 
        '079':[ 
        {'kod':'079201','vdadi':'KİLİS VD'}
        ], 
        '044':[ 
        {'kod':'044101','vdadi':'AKÇADAĞ MAL MD.'},                
        {'kod':'044102','vdadi':'ARAPKİR MAL MD.'},                
        {'kod':'044103','vdadi':'ARGUVAN MAL MD.'},                
        {'kod':'044109','vdadi':'BATTALGAZİ MAL MD.'},             
        {'kod':'044252','vdadi':'BEYDAĞI VD'},                     
        {'kod':'044104','vdadi':'DARENDE MAL MD.'},                
        {'kod':'044110','vdadi':'DOĞANYOL MAL MD.'},               
        {'kod':'044105','vdadi':'DOĞANŞEHİR MAL MD.'},             
        {'kod':'044251','vdadi':'FIRAT VD'},                       
        {'kod':'044106','vdadi':'HEKİMHAN MAL MD.'},               
        {'kod':'044111','vdadi':'KALE MAL MD.'},                   
        {'kod':'044112','vdadi':'KULUNCAK MAL MD.'},               
        {'kod':'044107','vdadi':'PÖTÜRGE MAL MD.'},                
        {'kod':'044113','vdadi':'YAZIHAN MAL MD.'},                
        {'kod':'044108','vdadi':'YEŞİLYURT MAL MD.'}
        ], 
        '045':[ 
        {'kod':'045113','vdadi':'AHMETLİ MAL MD.'},                
        {'kod':'045201','vdadi':'AKHİSAR VD'},
        {'kod':'045202','vdadi':'ALAŞEHİR VD'},
        {'kod':'045251','vdadi':'ALAYBEY VD'},
        {'kod':'045203','vdadi':'DEMİRCİ VD'},                     
        {'kod':'045114','vdadi':'GÖLMARMARA MAL MD.'},             
        {'kod':'045210','vdadi':'GÖRDES VD'},                      
        {'kod':'045204','vdadi':'KIRKAĞAÇ VD'},
        {'kod':'045115','vdadi':'KÖPRÜBAŞI MAL MD.'},        
        {'kod':'045211','vdadi':'KULA VD'},
        {'kod':'045252','vdadi':'MESİR VD'},                       
        {'kod':'045205','vdadi':'SALİHLİ ADİL ORA VD'},            
        {'kod':'045206','vdadi':'SARIGÖL VD'},                     
        {'kod':'045207','vdadi':'SARUHANLI VD'},                   
        {'kod':'045110','vdadi':'SELENDİ MAL MD.'},                
        {'kod':'045208','vdadi':'SOMA VD'},                        
        {'kod':'045209','vdadi':'TURGUTLU VD'}
        ], 
        '047':[ 
        {'kod':'047112','vdadi':'DARGEÇİT MAL MD.'},               
        {'kod':'047102','vdadi':'DERİK MAL MD.'},                  
        {'kod':'047261','vdadi':'KIZILTEPE VD'},                   
        {'kod':'047260','vdadi':'MARDİN VD'},                      
        {'kod':'047106','vdadi':'MAZIDAĞI MAL MD.'},               
        {'kod':'047107','vdadi':'MİDYAT MAL MD.'},                 
        {'kod':'047262','vdadi':'NUSAYBİN VD'},
        {'kod':'047109','vdadi':'ÖMERLİ MAL MD.'},        
        {'kod':'047110','vdadi':'SAVUR MAL MD.'},                  
        {'kod':'047113','vdadi':'YEŞİLLİ MAL MD.'}
        ], 
        '033':[ 
        {'kod':'033203','vdadi':'ANAMUR VD'},                      
        {'kod':'033107','vdadi':'AYDINCIK MAL MD.'},               
        {'kod':'033108','vdadi':'BOZYAZI MAL MD.'},
        {'kod':'033109','vdadi':'ÇAMLIYAYLA MAL MD.'},
        {'kod':'033201','vdadi':'ERDEMLİ VD'},                     
        {'kod':'033103','vdadi':'GÜLNAR MAL MD.'},
        {'kod':'033250','vdadi':'İSTİKLAL VD'},
        {'kod':'033204','vdadi':'KIZILMURAT VD'},                  
        {'kod':'033254','vdadi':'LİMAN VD'},                       
        {'kod':'033104','vdadi':'MUT MAL MD.'},                    
        {'kod':'033202','vdadi':'SİLİFKE VD'},
        {'kod':'033205','vdadi':'ŞEHİTKERİM VD'},        
        {'kod':'033255','vdadi':'TOROS VD'},                       
        {'kod':'033252','vdadi':'URAY VD'}
        ], 
        '048':[ 
        {'kod':'048261','vdadi':'BODRUM VD'},                      
        {'kod':'048109','vdadi':'DALAMAN MAL MD.'},                
        {'kod':'048102','vdadi':'DATÇA MAL MD.'},                  
        {'kod':'048262','vdadi':'FETHİYE VD'},                     
        {'kod':'048111','vdadi':'KAVAKLIDERE MAL MD.'},            
        {'kod':'048263','vdadi':'KÖYCEĞİZ VD'},                    
        {'kod':'048265','vdadi':'MARMARİS VD'},
        {'kod':'048264','vdadi':'MİLAS VD'},
        {'kod':'048260','vdadi':'MUĞLA VD'},
        {'kod':'048110','vdadi':'ORTACA MAL MD.'},                 
        {'kod':'048108','vdadi':'ULA MAL MD.'},                    
        {'kod':'048266','vdadi':'YATAĞAN VD'}
        ], 
        '049':[ 
        {'kod':'049101','vdadi':'BULANIK MAL MD.'},                
        {'kod':'049104','vdadi':'HASKÖY MAL MD.'},                 
        {'kod':'049105','vdadi':'KORKUT MAL MD.'},                 
        {'kod':'049102','vdadi':'MALAZGİRT MAL MD.'},              
        {'kod':'049260','vdadi':'MUŞ VD'},                         
        {'kod':'049103','vdadi':'VARTO MAL MD.'}
        ], 
        '050':[ 
        {'kod':'050107','vdadi':'ACIGÖL MAL MD.'},                 
        {'kod':'050101','vdadi':'AVANOS MAL MD.'},                 
        {'kod':'050102','vdadi':'DERİNKUYU MAL MD.'},              
        {'kod':'050103','vdadi':'GÜLŞEHİR MAL MD.'},               
        {'kod':'050104','vdadi':'HACIBEKTAŞ MAL MD.'},             
        {'kod':'050105','vdadi':'KOZAKLI MAL MD.'},                
        {'kod':'050260','vdadi':'NEVŞEHİR VD'},                    
        {'kod':'050106','vdadi':'ÜRGÜP MAL MD.'}
        ], 
        '051':[ 
        {'kod':'051106','vdadi':'ALTUNHİSAR MAL MD.'},             
        {'kod':'051262','vdadi':'BOR VD'},
        {'kod':'051103','vdadi':'ÇAMARDI MAL MD.'},
        {'kod':'051107','vdadi':'ÇİFTLİK MAL MD.'},        
        {'kod':'051260','vdadi':'NİĞDE VD'},                       
        {'kod':'051105','vdadi':'ULUKIŞLA MAL MD.'}
        ], 
        '052':[ 
        {'kod':'052101','vdadi':'AKKUŞ MAL MD.'},                  
        {'kod':'052102','vdadi':'AYBASTI MAL MD.'},                
        {'kod':'052201','vdadi':'BOZTEPE VD'},
        {'kod':'052113','vdadi':'ÇAMAŞ MAL MD.'},
        {'kod':'052114','vdadi':'ÇATALPINAR MAL MD.'},
        {'kod':'052115','vdadi':'ÇAYBAŞI MAL MD.'},
        {'kod':'052261','vdadi':'FATSA VD'},                       
        {'kod':'052104','vdadi':'GÖLKÖY MAL MD.'},                 
        {'kod':'052111','vdadi':'GÜLYALI MAL MD.'},                
        {'kod':'052112','vdadi':'GÜRGENTEPE MAL MD.'},
        {'kod':'052116','vdadi':'İKİZCE MAL MD.'},        
        {'kod':'052117','vdadi':'KABADÜZ MAL MD.'},                
        {'kod':'052118','vdadi':'KABATAŞ MAL MD.'},                
        {'kod':'052105','vdadi':'KORGAN MAL MD.'},
        {'kod':'052260','vdadi':'KÖPRÜBAŞI VD'},
        {'kod':'052106','vdadi':'KUMRU MAL MD.'},
        {'kod':'052107','vdadi':'MESUDİYE MAL MD.'},               
        {'kod':'052108','vdadi':'PERŞEMBE MAL MD.'},               
        {'kod':'052109','vdadi':'ULUBEY MAL MD.'},
        {'kod':'052262','vdadi':'ÜNYE VD'}
        ], 
        '080':[ 
        {'kod':'080101','vdadi':'BAHÇE MAL MD.'},                  
        {'kod':'080102','vdadi':'DÜZİÇİ MAL MD.'},                 
        {'kod':'080104','vdadi':'HASANBEYLİ MAL MD.'},             
        {'kod':'080260','vdadi':'KADİRLİ VD'},                     
        {'kod':'080201','vdadi':'OSMANİYE VD'},                    
        {'kod':'080105','vdadi':'SUMBAS MAL MD.'},                 
        {'kod':'080106','vdadi':'TOPRAKKALE MAL MD.'}
        ], 
        '053':[ 
        {'kod':'053263','vdadi':'ARDEŞEN VD'},
        {'kod':'053102','vdadi':'ÇAMLIHEMŞİN MAL MD.'},
        {'kod':'053261','vdadi':'ÇAYELİ VD'},
        {'kod':'053109','vdadi':'DEREPAZARI MAL MD.'},             
        {'kod':'053104','vdadi':'FINDIKLI MAL MD.'},               
        {'kod':'053108','vdadi':'GÜNEYSU MAL MD.'},                
        {'kod':'053110','vdadi':'HEMŞİN MAL MD.'},
        {'kod':'053105','vdadi':'İKİZDERE MAL MD.'},
        {'kod':'053111','vdadi':'İYİDERE MAL MD.'},        
        {'kod':'053106','vdadi':'KALKANDERE MAL MD.'},             
        {'kod':'053201','vdadi':'KAÇKAR VD'},                      
        {'kod':'053262','vdadi':'PAZAR VD'},                       
        {'kod':'053260','vdadi':'YEŞİLÇAY VD'}
        ], 
        '054':[ 
        {'kod':'054201','vdadi':'AKYAZI VD'},                      
        {'kod':'054252','vdadi':'ALİ FUAT CEBESOY VD'},            
        {'kod':'054202','vdadi':'GEYVE VD'},                       
        {'kod':'054251','vdadi':'GÜMRÜKÖNÜ VD'},                   
        {'kod':'054203','vdadi':'HENDEK VD'},                      
        {'kod':'054111','vdadi':'KARAPÜRÇEK MAL MD.'},             
        {'kod':'054204','vdadi':'KARASU VD'},                      
        {'kod':'054105','vdadi':'KAYNARCA MAL MD.'},               
        {'kod':'054107','vdadi':'KOCAALİ MAL MD.'},                
        {'kod':'054108','vdadi':'PAMUKOVA MAL MD.'},               
        {'kod':'054106','vdadi':'SAPANCA MAL MD.'},                
        {'kod':'054109','vdadi':'TARAKLI MAL MD.'}
        ], 
        '055':[ 
        {'kod':'055251','vdadi':'19 MAYIS VD'},                    
        {'kod':'055110','vdadi':'19 MAYIS MAL MD.'},               
        {'kod':'055101','vdadi':'ALAÇAM MAL MD.'},                 
        {'kod':'055109','vdadi':'ASARCIK MAL MD.'},                
        {'kod':'055113','vdadi':'AYVACIK MAL MD.'},                
        {'kod':'055202','vdadi':'BAFRA VD'},
        {'kod':'055203','vdadi':'ÇARŞAMBA VD'},        
        {'kod':'055252','vdadi':'GAZİLER VD'},                     
        {'kod':'055205','vdadi':'HAVZA VD'},                       
        {'kod':'055105','vdadi':'KAVAK MAL MD.'},                  
        {'kod':'055106','vdadi':'LADİK MAL MD.'},                  
        {'kod':'055111','vdadi':'SALIPAZARI MAL MD.'},             
        {'kod':'055112','vdadi':'TEKKEKÖY MAL MD.'},               
        {'kod':'055204','vdadi':'TERME VD'},                       
        {'kod':'055108','vdadi':'VEZİRKÖPRÜ MAL MD.'},             
        {'kod':'055114','vdadi':'YAKAKENT MAL MD.'},               
        {'kod':'055290','vdadi':'ZAFER VD'}
        ], 
        '057':[ 
        {'kod':'057101','vdadi':'AYANCIK MAL MD.'},                
        {'kod':'057261','vdadi':'BOYABAT VD'},                     
        {'kod':'057103','vdadi':'DURAĞAN MAL MD.'},                
        {'kod':'057107','vdadi':'DİKMEN MAL MD.'},                 
        {'kod':'057104','vdadi':'ERFELEK MAL MD.'},                
        {'kod':'057105','vdadi':'GERZE MAL MD.'},                  
        {'kod':'057108','vdadi':'SARAYDÜZÜ MAL MD.'},              
        {'kod':'057260','vdadi':'SİNOP VD'},                       
        {'kod':'057106','vdadi':'TÜRKELİ MAL MD.'}
        ], 
        '058':[ 
        {'kod':'058112','vdadi':'AKINCILAR MAL MD.'},              
        {'kod':'058113','vdadi':'ALTINYAYLA MAL MD.'},
        {'kod':'058101','vdadi':'DİVRİĞİ MAL MD.'},
        {'kod':'058114','vdadi':'DOĞANŞAR MAL MD.'},
        {'kod':'058102','vdadi':'GEMEREK MAL MD.'},                
        {'kod':'058115','vdadi':'GÖLOVA MAL MD.'},                 
        {'kod':'058103','vdadi':'GÜRÜN MAL MD.'},                  
        {'kod':'058104','vdadi':'HAFİK MAL MD.'},
        {'kod':'058105','vdadi':'İMRANLI MAL MD.'},
        {'kod':'058201','vdadi':'KALE VD'},                        
        {'kod':'058106','vdadi':'KANGAL MAL MD.'},                 
        {'kod':'058107','vdadi':'KOYULHİSAR MAL MD.'},
        {'kod':'058280','vdadi':'SİTE VD'},
        {'kod':'058109','vdadi':'SUŞEHRİ MAL MD.'},
        {'kod':'058260','vdadi':'ŞARKIŞLA VD'},        
        {'kod':'058116','vdadi':'ULAŞ MAL MD.'},                   
        {'kod':'058110','vdadi':'YILDIZELİ MAL MD.'},              
        {'kod':'058111','vdadi':'ZARA MAL MD.'}
        ], 
        '056':[ 
        {'kod':'056102','vdadi':'BAYKAN MAL MD.'},                 
        {'kod':'056104','vdadi':'ERUH MAL MD.'},                   
        {'kod':'056106','vdadi':'KURTALAN MAL MD.'},               
        {'kod':'056107','vdadi':'PERVARİ MAL MD.'},                
        {'kod':'056260','vdadi':'SİİRT VD'},                       
        {'kod':'056110','vdadi':'ŞİRVAN MAL MD.'}
        ], 
        '059':[
        {'kod':'059261','vdadi':'ÇERKEZKÖY VD'},
        {'kod':'059262','vdadi':'ÇORLU VD'},        
        {'kod':'059263','vdadi':'HAYRABOLU VD'},                   
        {'kod':'059264','vdadi':'MALKARA VD'},                     
        {'kod':'059108','vdadi':'MARM. EREĞLİSİ MAL MD.'},         
        {'kod':'059265','vdadi':'MURATLI VD'},                     
        {'kod':'059260','vdadi':'NAMIK KEMAL VD'},                 
        {'kod':'059106','vdadi':'SARAY MAL MD.'},                  
        {'kod':'059201','vdadi':'SÜLEYMANPAŞA VD'},
        {'kod':'059107','vdadi':'ŞARKÖY MAL MD.'}
        ], 
        '060':[ 
        {'kod':'060101','vdadi':'ALMUS MAL MD.'},                  
        {'kod':'060102','vdadi':'ARTOVA MAL MD.'},                 
        {'kod':'060110','vdadi':'BAŞÇİFTLİK MAL MD.'},             
        {'kod':'060261','vdadi':'ERBAA VD'},                       
        {'kod':'060262','vdadi':'NİKSAR VD'},                      
        {'kod':'060108','vdadi':'PAZAR MAL MD.'},                  
        {'kod':'060105','vdadi':'REŞADİYE MAL MD.'},               
        {'kod':'060111','vdadi':'SULUSARAY MAL MD.'},              
        {'kod':'060260','vdadi':'TOKAT VD'},                       
        {'kod':'060263','vdadi':'TURHAL VD'},                      
        {'kod':'060109','vdadi':'YEŞİLYURT MAL MD.'},              
        {'kod':'060264','vdadi':'ZİLE VD'}
        ], 
        '061':[ 
        {'kod':'061260','vdadi':'AKÇAABAT VD'},                    
        {'kod':'061102','vdadi':'ARAKLI MAL MD.'},                 
        {'kod':'061103','vdadi':'ARSİN MAL MD.'},                  
        {'kod':'061111','vdadi':'BEŞİKDÜZÜ MAL MD.'},
        {'kod':'061113','vdadi':'ÇARŞIBAŞI MAL MD.'},
        {'kod':'061104','vdadi':'ÇAYKARA MAL MD.'},
        {'kod':'061114','vdadi':'DERNEKPAZARI MAL MD.'},           
        {'kod':'061115','vdadi':'DÜZKÖY MAL MD.'},                 
        {'kod':'061116','vdadi':'HAYRAT MAL MD.'},                 
        {'kod':'061201','vdadi':'HIZIRBEY VD'},                    
        {'kod':'061280','vdadi':'KARADENİZ VD'},                   
        {'kod':'061117','vdadi':'KÖPRÜBAŞI MAL MD.'},              
        {'kod':'061105','vdadi':'MAÇKA MAL MD.'},                  
        {'kod':'061261','vdadi':'OF VD'},                          
        {'kod':'061107','vdadi':'SÜRMENE MAL MD.'},
        {'kod':'061112','vdadi':'ŞALPAZARI MAL MD.'},        
        {'kod':'061108','vdadi':'TONYA MAL MD.'},                  
        {'kod':'061262','vdadi':'VAKFIKEBİR VD'},                  
        {'kod':'061110','vdadi':'YOMRA MAL MD.'}
        ], 
        '062':[
        {'kod':'062101','vdadi':'ÇEMİŞGEZEK MAL MD.'},        
        {'kod':'062102','vdadi':'HOZAT MAL MD.'},                  
        {'kod':'062103','vdadi':'MAZGİRT MAL MD.'},                
        {'kod':'062104','vdadi':'NAZİMİYE MAL MD.'},               
        {'kod':'062105','vdadi':'OVACIK MAL MD.'},                 
        {'kod':'062106','vdadi':'PERTEK MAL MD.'},                 
        {'kod':'062107','vdadi':'PÜLÜMÜR MAL MD.'},                
        {'kod':'062260','vdadi':'TUNCELİ VD'}
        ], 
        '064':[ 
        {'kod':'064261','vdadi':'BANAZ VD'},                       
        {'kod':'064262','vdadi':'EŞME VD'},                        
        {'kod':'064103','vdadi':'KARAHALLI MAL MD.'},              
        {'kod':'064105','vdadi':'SİVASLI MAL MD.'},                
        {'kod':'064104','vdadi':'ULUBEY MAL MD.'},                 
        {'kod':'064260','vdadi':'UŞAK VD'}
        ], 
        '065':[ 
        {'kod':'065108','vdadi':'BAHÇESARAY MAL MD.'},             
        {'kod':'065101','vdadi':'BAŞKALE MAL MD.'},
        {'kod':'065109','vdadi':'ÇALDIRAN MAL MD.'},
        {'kod':'065102','vdadi':'ÇATAK MAL MD.'},
        {'kod':'065110','vdadi':'EDREMİT MAL MD.'},                
        {'kod':'065201','vdadi':'ERCİŞ VD'},                       
        {'kod':'065104','vdadi':'GEVAŞ MAL MD.'},                  
        {'kod':'065105','vdadi':'GÜRPINAR MAL MD.'},               
        {'kod':'065106','vdadi':'MURADİYE MAL MD.'},
        {'kod':'065107','vdadi':'ÖZALP MAL MD.'},        
        {'kod':'065111','vdadi':'SARAY MAL MD.'},                  
        {'kod':'065260','vdadi':'VAN VD'}
        ],
        '077':[ 
        {'kod':'077101','vdadi':'ALTINOVA MAL MD.'},               
        {'kod':'077102','vdadi':'ARMUTLU MAL MD.'},
        {'kod':'077103','vdadi':'ÇINARCIK MAL MD.'},        
        {'kod':'077201','vdadi':'YALOVA VD'}
        ], 
        '066':[ 
        {'kod':'066101','vdadi':'AKDAĞMADENİ MAL MD.'},            
        {'kod':'066109','vdadi':'AYDINCIK MAL MD.'},               
        {'kod':'066261','vdadi':'BOĞAZLIYAN VD'},
        {'kod':'066110','vdadi':'ÇANDIR MAL MD.'},
        {'kod':'066103','vdadi':'ÇAYIRALAN MAL MD.'},
        {'kod':'066104','vdadi':'ÇEKEREK MAL MD.'},
        {'kod':'066111','vdadi':'KADIŞEHRİ MAL MD.'},              
        {'kod':'066112','vdadi':'SARAYKENT MAL MD.'},              
        {'kod':'066105','vdadi':'SARIKAYA MAL MD.'},               
        {'kod':'066262','vdadi':'SORGUN VD'},
        {'kod':'066106','vdadi':'ŞEFAATLİ MAL MD.'},        
        {'kod':'066113','vdadi':'YENİFAKILI MAL MD.'},             
        {'kod':'066263','vdadi':'YERKÖY VD'},                      
        {'kod':'066260','vdadi':'YOZGAT VD'}
        ], 
        '067':[ 
        {'kod':'067110','vdadi':'ALAPLI MAL MD.'},
        {'kod':'067263','vdadi':'ÇAYCUMA VD'},        
        {'kod':'067264','vdadi':'DEVREK VD'},                      
        {'kod':'067113','vdadi':'GÖKÇEBEY MAL MD.'},               
        {'kod':'067261','vdadi':'KARADENİZ EREĞLİ VD'},            
        {'kod':'067280','vdadi':'KARAELMAS VD'},                   
        {'kod':'067201','vdadi':'UZUNMEHMET VD'}
        ], 
        '017':[ 
        {'kod':'017101','vdadi':'AYVACIK MAL MD.'},                
        {'kod':'017102','vdadi':'BAYRAMİÇ MAL MD.'},
        {'kod':'017261','vdadi':'BİGA VD'},
        {'kod':'017104','vdadi':'BOZCAADA MAL MD.'},
        {'kod':'017262','vdadi':'ÇAN VD'},
        {'kod':'017260','vdadi':'ÇANAKKALE VD'},        
        {'kod':'017106','vdadi':'ECEABAT MAL MD.'},                
        {'kod':'017107','vdadi':'EZİNE MAL MD.'},                  
        {'kod':'017263','vdadi':'GELİBOLU VD'},                    
        {'kod':'017109','vdadi':'GÖKÇEADA MAL MD.'},               
        {'kod':'017110','vdadi':'LAPSEKİ MAL MD.'},                
        {'kod':'017111','vdadi':'YENİCE MAL MD.'}
        ], 
        '018':[ 
        {'kod':'018110','vdadi':'ATKARACALAR MAL MD.'},            
        {'kod':'018112','vdadi':'BAYRAMÖREN MAL MD.'},
        {'kod':'018260','vdadi':'ÇANKIRI VD'},
        {'kod':'018101','vdadi':'ÇERKEŞ MAL MD.'},
        {'kod':'018102','vdadi':'ELDİVAN MAL MD.'},                
        {'kod':'018104','vdadi':'ILGAZ MAL MD.'},                  
        {'kod':'018111','vdadi':'KIZILIRMAK MAL MD.'},             
        {'kod':'018113','vdadi':'KORGUN MAL MD.'},                 
        {'kod':'018105','vdadi':'KURŞUNLU MAL MD.'},               
        {'kod':'018106','vdadi':'ORTA MAL MD.'},
        {'kod':'018108','vdadi':'ŞABANÖZÜ MAL MD.'},        
        {'kod':'018109','vdadi':'YAPRAKLI MAL MD.'}
        ], 
        '019':[ 
        {'kod':'019101','vdadi':'ALACA MAL MD.'},                  
        {'kod':'019102','vdadi':'BAYAT MAL MD.'},                  
        {'kod':'019109','vdadi':'BOĞAZKALE MAL MD.'},
        {'kod':'019260','vdadi':'ÇORUM VD'},
        {'kod':'019111','vdadi':'DODURGA MAL MD.'},
        {'kod':'019103','vdadi':'İSKİLİP MAL MD.'},        
        {'kod':'019104','vdadi':'KARGI MAL MD.'},                  
        {'kod':'019113','vdadi':'LAÇİN MAL MD.'},                  
        {'kod':'019105','vdadi':'MECİTÖZÜ MAL MD.'},
        {'kod':'019112','vdadi':'OĞUZLAR MAL MD.'},
        {'kod':'019106','vdadi':'ORTAKÖY MAL MD.'},                
        {'kod':'019107','vdadi':'OSMANCIK MAL MD.'},
        {'kod':'019261','vdadi':'SUNGURLU VD'},                    
        {'kod':'019110','vdadi':'UĞURLUDAĞ MAL MD.'}
        ], 
        '034':[ 
        {'kod':'034295','vdadi':'ADALAR VD'},                      
        {'kod':'034244','vdadi':'ANADOLU KURUMLAR VD'},            
        {'kod':'034291','vdadi':'ATIŞALANI VD'},                   
        {'kod':'034294','vdadi':'AVCILAR VD'},                     
        {'kod':'034284','vdadi':'BAKIRKÖY VD'},
        {'kod':'034264','vdadi':'BAYRAMPAŞA VD'},
        {'kod':'034251','vdadi':'BEŞİKTAŞ VD'},
        {'kod':'034265','vdadi':'BEYAZIT VD'},                     
        {'kod':'034281','vdadi':'BEYKOZ VD'},                      
        {'kod':'034297','vdadi':'BEYLİKDÜZÜ VD'},                  
        {'kod':'034266','vdadi':'BEYOĞLU VD'},
        {'kod':'034231','vdadi':'BOĞAZİÇİ KUR. VD'},               
        {'kod':'034230','vdadi':'BÜYÜK MÜK. VD. B VD'},            
        {'kod':'034204','vdadi':'BÜYÜKÇEKMECE VD'},
        {'kod':'034250','vdadi':'ÇAPA VD'},
        {'kod':'034206','vdadi':'ÇATALCA VD'},
        {'kod':'034234','vdadi':'DAVUTPAŞA VD'},                   
        {'kod':'034289','vdadi':'DIŞ TİC. VD'},                    
        {'kod':'034255','vdadi':'ERENKÖY VD'},                     
        {'kod':'034235','vdadi':'ESENLER VD'},                     
        {'kod':'034236','vdadi':'FATİH VD'},                       
        {'kod':'034268','vdadi':'GALATA VD'},                      
        {'kod':'034269','vdadi':'GAZİOSMANPAŞA VD'},               
        {'kod':'034270','vdadi':'GÖZTEPE VD'},                     
        {'kod':'034261','vdadi':'GÜNEŞLİ VD'},                     
        {'kod':'034259','vdadi':'GÜNGÖREN VD'},                    
        {'kod':'034278','vdadi':'HALKALI VD'},
        {'kod':'034256','vdadi':'HİSAR VD'},
        {'kod':'034271','vdadi':'HOCAPAŞA VD'},
        {'kod':'034249','vdadi':'İKİTELLİ VD'},
        {'kod':'034272','vdadi':'KADIKÖY VD'},
        {'kod':'034279','vdadi':'KAĞITHANE VD'},
        {'kod':'034285','vdadi':'KARTAL VD'},                      
        {'kod':'034254','vdadi':'KASIMPAŞA VD'},
        {'kod':'034273','vdadi':'KOCAMUSTAFAPAŞA VD'},             
        {'kod':'034260','vdadi':'KOCASİNAN VD'},                   
        {'kod':'034246','vdadi':'KOZYATAĞI VD'},
        {'kod':'034296','vdadi':'KÜÇÜKÇEKMECE VD'},
        {'kod':'034237','vdadi':'KÜÇÜKKÖY VD'},                    
        {'kod':'034262','vdadi':'KÜÇÜKYALI VD'},   
        {'kod':'034238','vdadi':'LALELİ VD'},                      
        {'kod':'034232','vdadi':'MARMARA KUR. VD'},                
        {'kod':'034247','vdadi':'MASLAK VD'},                      
        {'kod':'034274','vdadi':'MECİDİYEKÖY VD'},                 
        {'kod':'034275','vdadi':'MERCAN VD'},                      
        {'kod':'034239','vdadi':'MERTER VD'},                      
        {'kod':'034240','vdadi':'MEVLANAKAPI VD'},                 
        {'kod':'034287','vdadi':'NAKİL VASITA. VD'},               
        {'kod':'034267','vdadi':'NURUOSMANİYE VD'},                
        {'kod':'034263','vdadi':'PENDİK VD'},                      
        {'kod':'034241','vdadi':'RAMİ VD'},                        
        {'kod':'034258','vdadi':'RIHTIM VD'},                      
        {'kod':'034288','vdadi':'SARIGAZİ VD'},                    
        {'kod':'034283','vdadi':'SARIYER VD'},
        {'kod':'034203','vdadi':'SİLİVRİ VD'},
        {'kod':'034286','vdadi':'SULTANAHMET VD'},                 
        {'kod':'034242','vdadi':'SULTANBEYLİ VD'},                 
        {'kod':'034243','vdadi':'SÜLEYMANİYE VD'},
        {'kod':'034205','vdadi':'ŞİLE VD'},
        {'kod':'034276','vdadi':'ŞİŞLİ VD'},        
        {'kod':'034257','vdadi':'TUNA VD'},                        
        {'kod':'034245','vdadi':'TUZLA VD'},                       
        {'kod':'034233','vdadi':'ULAŞTIRMA VD'},
        {'kod':'034252','vdadi':'ÜMRANİYE VD'},
        {'kod':'034277','vdadi':'ÜSKÜDAR VD'},
        {'kod':'034292','vdadi':'YAKACIK VD'},                     
        {'kod':'034253','vdadi':'YEDİTEPE VD'},                    
        {'kod':'034293','vdadi':'YENİ BOSNA VD'},                  
        {'kod':'034280','vdadi':'ZEYTİNBURNU VD'},                 
        {'kod':'034248','vdadi':'ZİNCİRLİKUYU VD'}
        ], 
        '035':[ 
        {'kod':'035251','vdadi':'9 EYLÜL VD'},                     
        {'kod':'035213','vdadi':'ALİAĞA VD'},                      
        {'kod':'035266','vdadi':'BALÇOVA VD'},                     
        {'kod':'035255','vdadi':'BASMANE VD'},                     
        {'kod':'035201','vdadi':'BAYINDIR VD'},                    
        {'kod':'035254','vdadi':'BELKAHVE VD'},                    
        {'kod':'035202','vdadi':'BERGAMA VD'},                     
        {'kod':'035120','vdadi':'BEYDAĞ MAL MD.'},
        {'kod':'035264','vdadi':'BORNOVA VD'},
        {'kod':'035265','vdadi':'ÇAKABEY VD'},
        {'kod':'035212','vdadi':'ÇEŞME VD'},
        {'kod':'035269','vdadi':'ÇİĞLİ VD'},
        {'kod':'035105','vdadi':'DİKİLİ MAL MD.'},                 
        {'kod':'035268','vdadi':'EGE VD'},                         
        {'kod':'035106','vdadi':'FOÇA MAL MD.'},                   
        {'kod':'035267','vdadi':'GAZİEMİR VD'},                    
        {'kod':'035263','vdadi':'HASAN TAHSİN VD'},                
        {'kod':'035261','vdadi':'KADİFEKALE VD'},                  
        {'kod':'035107','vdadi':'KARABURUN MAL MD.'},              
        {'kod':'035256','vdadi':'KARŞIYAKA VD'},                   
        {'kod':'035207','vdadi':'KEMALPAŞA VD'},                   
        {'kod':'035257','vdadi':'KEMERALTI VD'},                   
        {'kod':'035210','vdadi':'KINIK VD'},
        {'kod':'035211','vdadi':'KİRAZ VD'},
        {'kod':'035258','vdadi':'KONAK VD'},                       
        {'kod':'035259','vdadi':'KORDON VD'},
        {'kod':'035215','vdadi':'MENDERES VD'},                    
        {'kod':'035203','vdadi':'MENEMEN VD'},
        {'kod':'035204','vdadi':'ÖDEMİŞ VD'},
        {'kod':'035114','vdadi':'SEFERİHİSAR MAL MD.'},            
        {'kod':'035209','vdadi':'SELÇUK VD'},
        {'kod':'035260','vdadi':'ŞİRİNYER VD'},        
        {'kod':'035262','vdadi':'TAŞITLAR VD'},
        {'kod':'035205','vdadi':'TİRE VD'},
        {'kod':'035206','vdadi':'TORBALI VD'},
        {'kod':'035208','vdadi':'URLA VD'},                        
        {'kod':'035252','vdadi':'YAMANLAR VD'}
        ], 
        '063':[ 
        {'kod':'063101','vdadi':'AKÇAKALE MAL MD.'},
        {'kod':'063262','vdadi':'BİRECİK VD'},
        {'kod':'063103','vdadi':'BOZOVA MAL MD.'},
        {'kod':'063109','vdadi':'CEYLANPINAR MAL MD.'},            
        {'kod':'063104','vdadi':'HALFETİ MAL MD.'},
        {'kod':'063110','vdadi':'HARRAN MAL MD.'},                 
        {'kod':'063105','vdadi':'HİLVAN MAL MD.'},
        {'kod':'063260','vdadi':'SİVEREK VD'},
        {'kod':'063107','vdadi':'SURUÇ MAL MD.'},
        {'kod':'063201','vdadi':'ŞEHİTLİK VD'},        
        {'kod':'063280','vdadi':'TOPÇUMEYDANI VD'},                
        {'kod':'063261','vdadi':'VİRANŞEHİR VD'}
        ], 
        '073':[ 
        {'kod':'073101','vdadi':'BEYTÜŞŞEBAB MAL MD.'},            
        {'kod':'073261','vdadi':'CİZRE VD'},                       
        {'kod':'073102','vdadi':'CİZRE MAL MD.'},                  
        {'kod':'073103','vdadi':'GÜÇLÜKONAK MAL MD.'},
        {'kod':'073104','vdadi':'İDİL MAL MD.'},
        {'kod':'073262','vdadi':'SİLOPİ VD'},                      
        {'kod':'073105','vdadi':'SİLOPİ MAL MD.'},
        {'kod':'073260','vdadi':'ŞIRNAK VD'},        
        {'kod':'073106','vdadi':'ULUDERE MAL MD.'}
        ]
}}";
            #endregion 
            var parsed = JsonConvert.DeserializeObject<VergiDairleri>(JSONVergi);

            if (SeciliIl.Length == 1)
            {
                SeciliIl = "00" + SeciliIl;
            }
            else if (SeciliIl.Length == 2)
            {
                SeciliIl = "0" + SeciliIl;
            }

            var SeciliIlVergiDairleri = parsed.Il.Where(x => x.Key == SeciliIl).ToList();
            var VergiDaireleri = SeciliIlVergiDairleri.FirstOrDefault().Value.ToList();
            return VergiDaireleri;
        }

        public async Task<JSONSehirler> Sehirler()
        {
            #region JsonVergi
            string JSONVergi = @"{'Sehirler' :[{
    'code': '01',
    'name': 'Adana'
    }, {
    'code': '02',
    'name': 'Adıyaman'
    }, {
    'code': '03',
    'name': 'Afyon'
    }, {
    'code': '04',
    'name': 'Ağrı'
    }, {
    'code': '05',
    'name': 'Amasya'
    }, {
    'code': '06',
    'name': 'Ankara'
    }, {
    'code': '07',
    'name': 'Antalya'
    }, {
    'code': '08',
    'name': 'Artvin'
    }, {
    'code': '09',
    'name': 'Aydın'
    }, {
    'code': '10',
    'name': 'Balıkesir'
    }, {
    'code': '11',
    'name': 'Bilecik'
    }, {
    'code': '12',
    'name': 'Bingöl'
    }, {
    'code': '13',
    'name': 'Bitlis'
    }, {
    'code': '14',
    'name': 'Bolu'
    }, {
    'code': '15',
    'name': 'Burdur'
    }, {
    'code': '16',
    'name': 'Bursa'
    }, {
    'code': '17',
    'name': 'Çanakkale'
    }, {
    'code': '18',
    'name': 'Çankırı'
    }, {
    'code': '19',
    'name': 'Çorum'
    }, {
    'code': '20',
    'name': 'Denizli'
    }, {
    'code': '21',
    'name': 'Diyarbakır'
    }, {
    'code': '22',
    'name': 'Edirne'
    }, {
    'code': '23',
    'name': 'Elazığ'
    }, {
    'code': '24',
    'name': 'Erzincan'
    }, {
    'code': '25',
    'name': 'Erzurum'
    }, {
    'code': '26',
    'name': 'Eskişehir'
    }, {
    'code': '27',
    'name': 'Gaziantep'
    }, {
    'code': '28',
    'name': 'Giresun'
    }, {
    'code': '29',
    'name': 'Gümüşhane'
    }, {
    'code': '30',
    'name': 'Hakkari'
    }, {
    'code': '31',
    'name': 'Hatay'
    }, {
    'code': '32',
    'name': 'Isparta'
    }, {
    'code': '33',
    'name': 'Mersin'
    }, {
    'code': '34',
    'name': 'İstanbul'
    }, {
    'code': '35',
    'name': 'İzmir'
    }, {
    'code': '36',
    'name': 'Kars'
    }, {
    'code': '37',
    'name': 'Kastamonu'
    }, {
    'code': '38',
    'name': 'Kayseri'
    }, {
    'code': '39',
    'name': 'Kırklareli'
    }, {
    'code': '40',
    'name': 'Kırşehir'
    }, {
    'code': '41',
    'name': 'Kocaeli'
    }, {
    'code': '42',
    'name': 'Konya'
    }, {
    'code': '43',
    'name': 'Kütahya'
    }, {
    'code': '44',
    'name': 'Malatya'
    }, {
    'code': '45',
    'name': 'Manisa'
    }, {
    'code': '46',
    'name': 'K.Maraş'
    }, {
    'code': '47',
    'name': 'Mardin'
    }, {
    'code': '48',
    'name': 'Muğla'
    }, {
    'code': '49',
    'name': 'Muş'
    }, {
    'code': '50',
    'name': 'Nevşehir'
    }, {
    'code': '51',
    'name': 'Niğde'
    }, {
    'code': '52',
    'name': 'Ordu'
    }, {
    'code': '53',
    'name': 'Rize'
    }, {
    'code': '54',
    'name': 'Sakarya'
    }, {
    'code': '55',
    'name': 'Samsun'
    }, {
    'code': '56',
    'name': 'Siirt'
    }, {
    'code': '57',
    'name': 'Sinop'
    }, {
    'code': '58',
    'name': 'Sivas'
    }, {
    'code': '59',
    'name': 'Tekirdağ'
    }, {
    'code': '60',
    'name': 'Tokat'
    }, {
    'code': '61',
    'name': 'Trabzon'
    }, {
    'code': '62',
    'name': 'Tunceli'
    }, {
    'code': '63',
    'name': 'Şanlıurfa'
    }, {
    'code': '64',
    'name': 'Uşak'
    }, {
    'code': '65',
    'name': 'Van'
    }, {
    'code': '66',
    'name': 'Yozgat'
    }, {
    'code': '67',
    'name': 'Zonguldak'
    }, {
    'code': '68',
    'name': 'Aksaray'
    }, {
    'code': '69',
    'name': 'Bayburt'
    }, {
    'code': '70',
    'name': 'Karaman'
    }, {
    'code': '71',
    'name': 'Kırıkkale'
    }, {
    'code': '72',
    'name': 'Batman'
    }, {
    'code': '73',
    'name': 'Şırnak'
    }, {
    'code': '74',
    'name': 'Bartın'
    }, {
    'code': '75',
    'name': 'Ardahan'
    }, {
    'code': '76',
    'name': 'Iğdır'
    }, {
    'code': '77',
    'name': 'Yalova'
    }, {
    'code': '78',
    'name': 'Karabük'
    }, {
    'code': '79',
    'name': 'Kilis'
    }, {
    'code': '80',
    'name': 'Osmaniye'
    }, {
    'code': '81',
    'name': 'Düzce'
    }] }";
            #endregion
            var Sehirler = JsonConvert.DeserializeObject<JSONSehirler>(JSONVergi);
            return Sehirler;
        }

        private string? VKNSorgulamaToken()
        {
            try
            {
                WebRequest request = WebRequest.Create("https://ivd.gib.gov.tr/tvd_server/assos-login");
                request.Method = "POST";
                string postData = "assoscmd=cfsession&rtype=json&fskey=intvrg.fix.session&fuserid=INTVRG_FIX&";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);

                var result = JsonConvert.DeserializeObject<MagazaBasvuruVKNToken>(responseFromServer);

                reader.Close();
                dataStream.Close();
                response.Close();

                return result.token;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private MagazaBasvuruVKNRespone? VKNSorgulamaIslemi(string Token, string Vkn,string Il,string VergiDairesi)
        {
            try
            {
                string jp = "{\"dogrulama\":{\"vkn1\":\"" + Vkn + "\",\"tckn1\": \"\",\"iller\":\""+Il+ "\",\"vergidaireleri\":\""+VergiDairesi+"\"}}";

                WebRequest request = WebRequest.Create("https://ivd.gib.gov.tr/tvd_server/dispatch");
                request.Method = "POST";
                string postData = "cmd=vergiNoIslemleri_vergiNumarasiSorgulama&callid=ff81dd010b12d-8&pageName=R_INTVRG_INTVD_VERGINO_DOGRULAMA&token=" + Token + "&jp=" + jp;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);

                var result = JsonConvert.DeserializeObject<MagazaBasvuruVKNRespone>(responseFromServer);

                reader.Close();
                dataStream.Close();
                response.Close();

                return result;
            }
            catch (Exception e)
            {
                return null;
            }

        }     
    }
}
