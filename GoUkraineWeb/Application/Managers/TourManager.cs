using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Managers
{
    public class TourManager
    {
        public TourVM TourDescription(int id)
        {
            var tourList = new List<TourVM>();
            /*TURKEY*/
            tourList.Add(
                new TourVM
                {
                    Id = 1,
                    Name = "Турція",
                    Start = new DateTime(2021, 7, 1, 14, 0, 0),
                    End = new DateTime(2021, 7, 8, 9, 10, 0),
                    DeparturePlace = "Київ",
                    ArivalFromPlace = "Анталья",
                    FoodSupplyType = "все включено",
                    TravelerTypes = "2 дорослих",
                    PeopleCount = 2,
                    HotelStars = 4,
                    Costs = 16_412,
                    Carousel = new Carousel
                    {
                        ImgList = new List<CarouselImg>()
                        {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/grand-hotel-derin/0.jpg",
                                Alt = "Beldibi",
                                DataRemote= "/images/hotels/grand-hotel-derin/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/grand-hotel-derin/1.jpg",
                                Alt = "Beldibi",
                                DataRemote= "/images/hotels/grand-hotel-derin/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/grand-hotel-derin/2.jpg",
                                Alt = "Beldibi",
                                DataRemote= "/images/hotels/grand-hotel-derin/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/grand-hotel-derin/3.jpg",
                                Alt = "Beldibi",
                                DataRemote= "/images/hotels/grand-hotel-derin/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/grand-hotel-derin/4.jpg",
                                Alt = "Beldibi",
                                DataRemote= "/images/hotels/grand-hotel-derin/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/grand-hotel-derin/5.jpg",
                                Alt = "Beldibi",
                                DataRemote= "/images/hotels/grand-hotel-derin/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/grand-hotel-derin/6.jpg",
                                Alt = "Beldibi",
                                DataRemote= "/images/hotels/grand-hotel-derin/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 7,
                                Src ="/images/hotels/grand-hotel-derin/7.jpg",
                                Alt = "Beldibi",
                                DataRemote= "/images/hotels/grand-hotel-derin/7.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 8,
                                Src ="/images/hotels/grand-hotel-derin/8.jpg",
                                Alt = "Beldibi",
                                DataRemote= "/images/hotels/grand-hotel-derin/8.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                        },
                        ThumbList = new List<CarouselThumb>()
                        {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/grand-hotel-derin/thumb/0.jpg",
                                Alt = "Beldibi",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/grand-hotel-derin/thumb/1.jpg",
                                Alt = "Beldibi",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/grand-hotel-derin/thumb/2.jpg",
                                Alt = "Beldibi",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/grand-hotel-derin/thumb/3.jpg",
                                Alt = "Beldibi",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/grand-hotel-derin/thumb/4.jpg",
                                Alt = "Beldibi",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/grand-hotel-derin/thumb/5.jpg",
                                Alt = "Beldibi",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/grand-hotel-derin/thumb/6.jpg",
                                Alt = "Beldibi",
                            },
                            new CarouselThumb
                            {
                                Id = 7,
                                Src= "/images/hotels/grand-hotel-derin/thumb/7.jpg",
                                Alt = "Beldibi",
                            },
                            new CarouselThumb
                            {
                                Id = 8,
                                Src= "/images/hotels/grand-hotel-derin/thumb/8.jpg",
                                Alt = "Beldibi",
                            }
                        }
                    },
                    Services = new List<TourService>
                    {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія"
                        },
                    },
                    InfoBlocks = new List<TourInfoBlock>
                    {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <table class='table table-striped'>
                                            <tbody>
                                              <tr>
                                                <th scope = 'row'> Час заїзду / від'їзду</th>
                                                <td>Час заселення в номер - після 14:00, час здачі номера в день від'їзду - до 12:00.</td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Розміщення </th>
                                                <td> Готель знаходиться в курортному селищі Бельдібі, в 15 км від центру Кемера, в 65 км від аеропорту Анталії.Загальна площа території готелю - 4500 кв.м.Рік відкриття готелю - 2005 Остання Реновація - 2015 р</td>
                                                 </tr>
                                              <tr>
                                                <th scope = 'row'> Розміщення </th>
   
                                                   <td>
                                                     Готельний комплекс складає один 5-поверхового головного будинку і одного 3-поверхового корпусу Анекс.Всього 280 номерів.
                                                     <span>До розміщення пропонуються номери категорій:</span>
                                                  <ul>
                                                    <li><strong>Economy</strong> (15 кв.м, однокімнатний номер в корпусі Анекс, макс. 2 + 1 чол.)</li>
                                                    <li><strong>Standard</strong>(22 кв.м, однокімнатний номер, в основній будівлі, макс. 2 + 1 чол.)</li>
                                                  </ul>
                                                  Розміщення з домашніми тваринами заборонено.
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>ванна</li>
                                                    <li>фен</li>
                                                    <li>туалетні приналежності</li>
                                                    <li>кондиціонер</li>
                                                    <li>LCD ТВ</li>
                                                    <li>телефон</li>
                                                    <li>балкон</li>
                                                    <li>Wi-Fi (платно)</li>
                                                    <li>сейф (платно)</li>
                                                    <li>міні-бар (безкоштовно, 1,5 л води 1 раз по заїзд)</li>
                                                    <li>прибирання(5 разів на тиждень)</li>
                                                    <li>зміна постільної білизни та рушників(3 рази в тиждень)</li>
                                                    <li>цілодобовий сервіс(платно)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Територія </th>
                                                <td>
                                                  <ul>
                                                    <li> Wi - Fi </li>
                                                    <li> обмін валюти</li>
                                                    <li>прокат авто</li>
                                                    <li>магазин</li>
                                                    <li>цілодобова стійка реєстрації</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Опис All Inclusive</th>
                                                <td>
                                                  Готель пропонує харчування по системі<b> All Inclusive:</b>
                                                  <ul>
                                                    <li>сніданок (07: 00-09: 00, головний ресторан, шведський стіл)</li>
                                                    <li>пізній сніданок(09: 00-10: 00, головний ресторан, шведський стіл)</li>
                                                    <li>обід(12: 30-14: 00, головний ресторан, шведський стіл)</li>
                                                    <li>вечеря(19: 30-21: 00, головний ресторан, шведський стіл)</li>
                                                    <li>пізню вечерю(23: 00-23: 30 головний ресторан, нічний суп)</li>
                                                    <li>закуски в перебігу дня(11: 00-16: 00)</li>
                                                    <li>чай, кава, випічка(17: 00-18: 00)</li>
                                                    <li>алкогольні та безалкогольні напої місцевого виробництва</li>
                                                  </ul>
                                                  <p>За додаткову плату: всі напої після 22:00.</p>
                                                  <p><em>* Адміністрація готелю залишається за собою право вносить зміни в концепцію харчування.</em></p>
                                                </td>
                                              <tr>
                                                <th scope = 'row'> Ресторани і бари</th>
                                                <td>
                                                  <b>Ресторани:</b>
                                                  <ul>
                                                    <li>головний ресторан (07: 00-23: 30)</li>
                                                  </ul>
                                                  <b>Бари:</b>
                                                  <ul>
                                                    <li>бар у бассейна(10: 00-22: 00)</li>
                                                    <li>снэк-бар(11: 00-16: 00)</li>
                                                  </ul>
                                                  <p>Керівництво готелю залишає за собою право вносити зміни в години роботи всіх об'єктів на території готелю і заходів (зазначених в описі) без попереднього повідомлення і в залежності від погодних умов.</p>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Мова </th>
                                                <td> Персонал готелю говорить на турецькому, російською, англійською та німецькою мовами.</td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Важлива інформація</th>
                                                <td>
                                                  <p>Розміщення двох чоловіків в одному номері заборонено.</p>
                                                  <p>Куріння в строго відведених місцях.</p>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Кредитні картки</th>
                                                <td>До оплати приймаються картки Visa і Master Card.</td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    Власний піщано-галькові, в 100 м від готелю. Між пляжем і готельної зоною проходить автомобільна дорога.
                                    <p>Пляжне обладнання - безкоштовно. Пляжні рушники - платно. Вхід в море - галька.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/turkey/beldibi.jpg' /></p>
                                      <p class='mt-3'>Бельдібі(Beldibi) - курортне селище на узбережжі Середземного моря.Розташований в підніжжя гірської системи Східні таври, в 25 км південніше міста Анталья, 17 кілометрах від Кемера.</p>
                                      <p>Свою назву містечко отримало по імені невеликої річки, довжина якої близько 4 км.У минулому тут було звичайне село, жителі якої, в основному, займалися вирощуванням апельсинів.Але з середини 80-х років минулого століття, почав розвиватися туризм, будуються недорогі готелі.</p>
                                      <p>Бельдібі спочатку позиціонувався як бюджетний курорт, де проживання та послуги доступні всім. Але на початку 21 століття почалося будівництво вишуканих готелів.Це місце ідеально підходить для любителів природи (особливо гірських місцевостей) і активного відпочинку.Тут дуже популярні походи в гори, маршрут проходить по дуже мальовничій місцевості.</p>
                                      <p>Курорт розташований в довгій вузькій долині і протягнутий уздовж узбережжя паралельно схилам Тавра на 7 км.</p>
                                      <p>Пляж Бельдібі, в основному, складається з великої гальки.Близько деяких готелів є насипний пісок.</p>
                                      <h4 class='text-info'>Пам'ятки і розваги</h4>
                                      <p>Розваги обмежуються басейнами з невеликими гірками, які є в багатьох готелях.Для розваг краще відправитися в міста Кемер де дискотеки та багато нічних клубів. Там же є і великі торгові центри, які відсутні на курорті.</p>
                                      <p>Розваг в Бельдібі небагато. У безпосередній близькості тільки гори, куди можна відправитися самостійно або з екскурсії.</p>
                                      <p>Якщо ви хочете дійсно подивитися щось цікаве, то варто з'їздити в старовинне місто Фазеліс, яке було заснованне колоністами з Родосу в 7 столітті до н. е. і вважався великим торговим і військовим центром. </p>
                                      <p>З Бельдібі дуже популярні екскурсії в Анталію, в руїнах античного міста Миру, в древній ликийский Термессос і, нарешті, в Каньйон Гейнюк, Який веде на мальовничий Ликийский шлях.</p>
                                      <p>За понеділка в Бельдібі працює виїзний ринок.</p>
                                      <p>Джерело: <a href = 'https://turktrip.ru/kemer/beldibi'> https://turktrip.ru/kemer/beldibi</a></p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <ul>
                                                <li>відкритий басейн (220 кв.м)</li>
                                                <li>водні гірки</li>
                                              </ul>
                                              <b>бесплатно:</b>
                                              <ul>
                                                <li>фітнес зал</li>
                                                <li>водне поло</li>
                                                <li>анімація</li>
                                                <li>настільний теніс</li>
                                                <li>дартс</li>
                                                <li>більярд</li>
                                                <li>дискотека</li>
                                              </ul>
                                              <b>За додаткову плату:</b>
                                              <ul>
                                                <li>хамам</li>
                                                <li>сауна</li>
                                                <li>масаж</li>
                                                <li>прокат велосипедів</li>
                                              </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>дитячий басейн</li>
                                                <li>дитяча анімація</li>
                                                <li>високі стільці в ресторані</li>
                                                <li>дитячий ігровий майданчик</li>
                                                <li>дитяче ліжечко (за запитом)</li>
                                              </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <p>Купальний сезон триває з травня по жовтень. Найбільш жаркі місяці - липень і серпень, коли стовпчик термометра піднімається до +32 Beldibi + 34. У літній період опадів майже ніколи не буває, лише в квітні та жовтні іноді пройде невеликий дощик. Кращий час для поїздки - червень і вересень, коли погода в Бельдібі Найбільш комфортна - не дуже жарко і не прохолодно.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li>будь-ласка пам'ятайте, що це економ варіант;</li>
                                          <li>готель був збудований у 2005 році і остання реновація була 2015 року, тому незначні подряпинки у ванні обо ще десь це можливі;</li>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
                    }
                }
            );

            /*EGYPT*/

            /*  Sharm Inn Amarein*/
            tourList.Add(
               new TourVM
               {
                   Id = 2,
                   Name = "Египт",
                   Start = new DateTime(2021, 7, 3, 14, 4, 5),
                   End = new DateTime(2021, 7, 10, 18, 5, 5),
                   DeparturePlace = "Київ",
                   ArivalFromPlace = "Шарм-эль-Шейх",
                   FoodSupplyType = "все включено",
                   TravelerTypes = "1 дорослий",
                   PeopleCount = 1,
                   HotelStars = 4,
                   Costs = 11_645,
                   Carousel = new Carousel
                   {
                       ImgList = new List<CarouselImg>()
                       {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/0.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/1.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/2.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/3.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/grand-hotel-derin/4.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/grand-hotel-derin/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/5.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/6.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 7,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/7.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/7.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 8,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/8.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/8.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                       },
                       ThumbList = new List<CarouselThumb>()
                       {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/0.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/1.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/2.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/3.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/4.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/5.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/6.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 7,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/7.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 8,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/8.jpg",
                                Alt = "Sharm el Sheikh",
                            }
                       }
                   },
                   Services = new List<TourService>
                   {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія"
                        },
                   },
                   InfoBlocks = new List<TourInfoBlock>
                   {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <p>На території готелю є відкритий басейн для дорослих і дітей, ресторан, бар і кальянная, а також SPA-центр, де можна поніжитися в турецькій лазні або попаритися в сауні. До піщаного пляжу за кілька хвилин доставить готельний шатл-бас.</p>
                                          <table class='table table-striped'>
                                            <tbody>
                                               <tr>
                                                <th scope = 'row'> Розташування </th>
                                                <td> Готель знаходиться в 2 км від моря, в районі Хадаба, в 2 км від центру міста і в 20 км від аеропорту м Шарм-ель-Шейх. Загальна площа території готелю - 14200 кв. м. Рік побудови готелю - 2002 Остання реновація - 2018 р</td>
                                                </tr>
                                              <tr>
                                                <th scope = 'row'> Розміщення </th>
                                                   <td>
                                                     Готель складається з трьох 2-поверхових корпусів.
                                                     <span>Всього 90 номерів.</span>
                                                     <span>До розміщення пропонуються:<span>
                                                  <ul>
                                                    <li><strong>Standart Room</strong> (30 кв. М, двоспальне або 2 односпальні ліжка)</li>
                                                 </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>ванна кімната</li>
                                                    <li>фен</li>
                                                    <li>туалетно-косметичні приналежності</li>
                                                    <li>кондиціонер</li>
                                                    <li>ТВ</li>
                                                    <li>телефон</li>
                                                    <li>балкон \ тераса (не у всіх номерах)</li>
                                                    <li>міні-бар (платно)</li>
                                                    <li>прибирання номера (щодня)</li>
                                                    <li>зміна постільної білизни (2 рази на тиждень)</li>
                                                 </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Територія </th>
                                                <td>
                                                  <ul>
                                                    <li>Wi-Fi в лобі (безкоштовно)</li>
                                                    <li>сейф на ресепшен (безкоштовно)</li>
                                                    <li>парковка (безкоштовно)</li>
                                                    <li>пральня (платно)</li>
                                                    <li>послуги доктора (платно)</li>
                                                    <li>прокат автомобіля (платно)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Опис All Inclusive</th>
                                                <td>
                                                  Готель пропонує харчування по системі<b> All Inclusive:</b>
                                                  <ul>
                                                    <li>сніданок (07: 00-10: 00)</li>
                                                    <li>пізній сніданок(09: 00-10: 00, головний ресторан, шведський стіл)</li>
                                                    <li>обід (13: 00-15: 00)</li>
                                                    <li>вечеря (19: 00-21: 00)</li>
                                                    <li>місцеві алкогольні і безалкогольні напої</li>
                                                  </ul>
                                               </td>
                                              <tr>
                                                <th scope = 'row'> Ресторани і бари</th>
                                                <td>
                                                 <ul>
                                                    <li>головний ресторан (сніданок, обід, вечеря)</li>
                                                    <li>бар на пляжі (10: 00-17: 00; платно)</li>
                                                    <li>бар у бассейна (10:00-22:00)</li>
                                                    <li>кальянная (платно)</li>
                                                  </ul>
                                                  <p>Готель залишає за собою право вносити зміни в розклад роботи барів, кафе, ресторанів.</p>
                                                </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    Власний піщаний, в 3 км від готелю.
                                    <p>Шаттл-бас до пляжу - безкоштовно.</p>
                                    <p>Пляжний інвентар - безкоштовно.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/hotels/egypt/sharm-el/sharm-el-1.jpg' /></p>
                                      <p>Різноманітність видів морських мешканців і сотні коралових рифів Червоного моря роблять Шарм-ель-Шейх особливо привабливим для любителів дайвінгу та еко-туризму. Заснована на туризмі економіка цього міста, розташованого на Синайському півострові, за останні кілька десятиліть пережила значний підйом, що стало причиною виникнення першокласних курортів і розквіту нічного життя.</p>
                                      <p>Серце всього Шарм-ель-Шейха - це Наама-Бей найяскравіший район курорту. Наама-Бей славиться своєю відмінною інфраструктурою. Тут є прогулянкова набережна, казино, безліч ресторанів, барів і кафе, розважальні клуби, нічні дискотеки, екскурсійні бюро та безліч інших закладів.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <b>безкоштовно:</b>
                                              <ul>
                                                <li>відкритий басейн</li>
                                                <li>тренажерний зал</li>
                                              </ul>
                                              <b>За додаткову плату:</b>
                                              <ul>
                                                <li>настільний теніс</li>
                                                <li>SPA-процентним</li>
                                                <li>турецька лазня</li>
                                                <li>сауна</li>
                                                <li>масаж</li>
                                                <li>більярд</li>
                                              </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>дитячий відкритий басейн</li>
                                                <li>дитяче ліжечко (за запитом)</li>
                                                <li>високі стільці в ресторані</li>
                                                <li>дитячі стільці в ресторані</li>
                                              </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в січні</h5>
                                    <p>Погода в січні в Шарм-ель-Шейху суха. Опади вірогідні, але якщо з неба і впадуть краплі, то цього ніхто не помітить. Якщо вдень стовпчик термометра дотягує до + 22 ° C, так само як і тіло акваторії; то після заходу ситуація змінюється. Термометр покаже тільки + 13 ° C. Погода в Шарм-ель-Шейху в січні не дасть розслабитися. Теплі речі Повинні занять почесне місце у валізі. Але нехтувати купальник не варто! У басейнах при готелях температура води незмінно річна. А в безвітряну погоду можна з комфортом поніжитися під сонцем біля моря. Головне пам'ятати, червоний прапор на пляжі - знак заборони на купання.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в лютому</h5>
                                    <p>Під кінець зимового періоду ситуація в Шарм-ель-Шейху мало відрізняється від попередньої їй. Море »подморожена». Його температура чи дотягує до двадцяти градусів за Цельсієм зі знаком плюс. Це погода в Шарм-ель-Шейху в лютому постаралася. Зате, якщо купання НЕ є Наріжним каменем подорожі, можна чудово провести час. В Єгипті чимало пам'ятки, яким НЕ насолодишся в високий сезон і під палючим сонцем. У світлий час доби погода в лютому в Шарм-ель-Шейху нагріє повітря до + 25 ° C в середньому. Після заходу стане в нагоді вітровка, за вікном буде всього + 17 ° C. Серед інших плюсів - відсутність дощів.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в березні</h5>
                                    <p>Поки що на березі комфортно тільки приймати сонячні ванни. Погода в Шрам-ель-Шейху в березні подбала лише про теплі навколо. У воді ж всього + 21 ° C! Зате на березі можна знемагати від спеки, температура повітря часом доходить до + 35 ° C. При таких успіхи, навіть море «відтане» на градус-другий. Середніми ж показниками прогріву повітря стануть + 24 ° C в світлий час доби і + 17 ° C після заходу сонця. Но погода в марте в Шарм-Эль-Шейхе достаточно динамична. И динамика эта положительна. То есть от декады к декаде будет жарче. При этом о дождях можно не беспокоиться, их вероятность сведена к минимуму. Но теплые вещи для вечерних прогулок и на случай сильного ветра (который непременно налетит) взять с собой рекомендуется.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в квітні</h5>
                                    <p>Погода в квітні в Шарм-ель-Шейху непередбачувана в вітро-плані. Так що, побоюватися варто «хамсин». Піщаний вихор налітає раптово, і також несподівано стихає. Теплі речі НЕ знадобляться вже і по ночах, прогретими до + 23 ° C в середньому. Зате довгий рукав або спеціальні засоби врятують від комарів, які можуть докучати відпочиваючим.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в травні</h5>
                                    <p>Погода в Шарм-ель-Шейху в травні Адекватне нікуди. Середньоденний тепло досягає + 34 ° C. З урахуванням кліматичної сухості, відчуття від такого режиму найприємніші. Головне не забувати користуватися кремом від сонця, промені його підступні. Ночами градусник термометра опускається до + 24 ° C. Заспокоюють вітру, а разом з ними і Акваторія, прогріта до + 26 ° C. Маленьким гостям курорту вже НЕ загрожують морські хвилювання. До речі, погода в травні в Шарм-ель-Шейху, кілька підступна. Мінусом штиль стануть комарі, варто подбати про захист.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в червні</h5>
                                    <p>Ось середніх + 37 ° C і до максимальних + 46 ° C - такий градусний розкид очікує біля берега Червоного моря. Погода в Шарм-ель-Шейху в червні все ще милосердна. Низький рівень вологості дозволяє дихати на повні груди, особливо після заходу сонця. Тоді градусник покаже всього + 26 ° C в середньому. А як нагрілося море! + 27 ° C - це коли в воді хочеться проводить годинник. І вся ця сіненебая безхмарність укупі з сухою, але все-таки спекою, може навіть набриднути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в липні</h5>
                                    <p>Погода в Шарм-ель-Шейху в червні дружить з цифрами за сорок. Добре, що в нічні години стовпчик термометра опускається до позначки в + 27 ° C в середньому. Але денні + 40 ° C і більше нікого тут НЕ дивуватися в цей час. Навіщо ж їхати в таке пекло, будучи в равом розумі? Погода в липні в Шарм-ель-Шейху знайшла відповідь. Низька вологість перетворює курорт в подобу сауни з сухою парою - жарко, але добре. Ось сонячного удару застрахує панама, тінь і своєчасну втечу в прохолоду кондиціонованих приміщень (зазвичай з полудня і до п'ятої вечора).</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в серпні</h5>
                                    <p>Обжигающий пісок, сліпуче сонце і соковита зелень навколо - таким буде Серпневий Шарм-ель-Шейх. Середньоденна температура досягає позначки в + 43 ° C! У такі моменти дякуєш винахідника кондиціонерів! Погода в Шарм-ель-Шейху в серпні немов піч. Особливо з полудня і до вечора. Якщо чесно, наслідках і ночами. Після заходу градусник демонструє + 30 ° C. За рахунок сухості клімату, навіть таке пекло терпимо. Акваторія, нагріта до + 29 ° C, завжди допоможе охолонути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в вересні</h5>
                                    <p>Середньоденна температура знижується до + 38 ° C. Погода в Шарм-ель-Шейху в вересні набагато м'якше предидущемесячной. Нічна температура буде дорівнює середнім + 26 ° C. Тільки не потрібно чекати прохолоди в першій же декаді, вона буде скоріше схожа на серпневу ситуацію. Поспішати розлучатися з коштами від сонячних опіків і головних уборів Не варто. Акваторія анітрохи ні остигає, все той же + 29 ° C.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в жовтні</h5>
                                    <p>Погода в Шарм-ель-Шейху в жовтні знає відповідь. Пора в Єгипет! Доказів на користь цього напрямку маса. Море ще тепле, його температура дорівнює + 27 ° C. Турботливі службовці готелю навіть розчищають місцями захід у море від каменів! Залишається тільки насолоджуватися купання в солоній воді. Середньоденна температура досягає + 33 ° C. Вночі цифра змінюється на + 27 ° C. Таким чином, при світлі дня терпимо жарко, а після заходу сонця - саме те. А ще погода в жовтні в Шарм-ель-Шейху екскурсійно-адекватна. Взимку заважають вітру, влітку спека, а міжсезоння прекрасно підійде для знайомства з визначними пам'ятками.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в листопаді</h5>
                                    <p>Погода в Шарм-ель-Шейху в листопаді того підтвердження. Вдень температура тримається на середньому рівні в + 28 ° C. Ночами курорт остигає до + 19 ° C. замерзнути при такому розкладі складно, але можна. Все-таки пустеля колом, і тепла кофта повинна занять почесне місце в багажі (дуже стане в нагоді після заходу). Навіть море ще в тонусі, його тепло одно + 26 ° C, що цілком можна купатися. Погода в листопаді в Шарм-ель-Шейху буває і мокрою. Правда. Сумарна кількість осадом мізерно мало, а тому переживання в сторону.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в грудні</h5>
                                    <p>Погода в Шарм-ель-Шейху в грудні різниться як раз по районному фактора. Проблема в властивих Єгипту зимових вітрах. Старт місяці - це середньоденні + 24 ° C, в цей час і море прогріти до комфортних + 25 ° C, і ночами досить кофтинки тепліше, щоб не змерзнути. У той же час днем ​​- тепло: можна позасмагати в своє задоволення або відправитися на екскурсію. На комфорті більш пізнього перебування позначиться розташування готелю. Ідеалом стане будь-яка з бухт - захищений від вітру пляж - щастя зимових туристів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
                   }
               }
           );
            /*  Sharm Inn Amarein*/
            tourList.Add(
               new TourVM
           {
               Id = 3,
               Name = "Египт",
               Start = new DateTime(2021, 7, 3, 14, 4, 5),
               End = new DateTime(2021, 7, 10, 18, 5, 5),
               DeparturePlace = "Київ",
               ArivalFromPlace = "Шарм-эль-Шейх",
               FoodSupplyType = "все включено",
               TravelerTypes = "1 дорослий",
               PeopleCount = 1,
               HotelStars = 4,
               Costs = 11_645,
               Carousel = new Carousel
               {
                   ImgList = new List<CarouselImg>()
                   {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/0.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/1.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/2.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/3.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/grand-hotel-derin/4.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/grand-hotel-derin/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/5.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/6.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 7,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/7.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/7.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 8,
                                Src ="/images/hotels/egypt/sharm-inn-amarein-4/8.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/8.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                   },
                   ThumbList = new List<CarouselThumb>()
                   {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/0.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/1.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/2.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/3.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/4.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/5.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/6.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 7,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/7.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 8,
                                Src= "/images/hotels/egypt/sharm-inn-amarein-4/thumb/8.jpg",
                                Alt = "Sharm el Sheikh",
                            }
                   }
               },
               Services = new List<TourService>
               {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія"
                        },
               },
               InfoBlocks = new List<TourInfoBlock>
               {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <p>На території готелю є відкритий басейн для дорослих і дітей, ресторан, бар і кальянная, а також SPA-центр, де можна поніжитися в турецькій лазні або попаритися в сауні. До піщаного пляжу за кілька хвилин доставить готельний шатл-бас.</p>
                                          <table class='table table-striped'>
                                            <tbody>
                                               <tr>
                                                <th scope = 'row'> Розташування </th>
                                                <td> Готель знаходиться в 2 км від моря, в районі Хадаба, в 2 км від центру міста і в 20 км від аеропорту м Шарм-ель-Шейх. Загальна площа території готелю - 14200 кв. м. Рік побудови готелю - 2002 Остання реновація - 2018 р</td>
                                                </tr>
                                              <tr>
                                                <th scope = 'row'> Розміщення </th>
                                                   <td>
                                                     Готель складається з трьох 2-поверхових корпусів.
                                                     <span>Всього 90 номерів.</span>
                                                     <span>До розміщення пропонуються:<span>
                                                  <ul>
                                                    <li><strong>Standart Room</strong> (30 кв. М, двоспальне або 2 односпальні ліжка)</li>
                                                 </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>ванна кімната</li>
                                                    <li>фен</li>
                                                    <li>туалетно-косметичні приналежності</li>
                                                    <li>кондиціонер</li>
                                                    <li>ТВ</li>
                                                    <li>телефон</li>
                                                    <li>балкон \ тераса (не у всіх номерах)</li>
                                                    <li>міні-бар (платно)</li>
                                                    <li>прибирання номера (щодня)</li>
                                                    <li>зміна постільної білизни (2 рази на тиждень)</li>
                                                 </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Територія </th>
                                                <td>
                                                  <ul>
                                                    <li>Wi-Fi в лобі (безкоштовно)</li>
                                                    <li>сейф на ресепшен (безкоштовно)</li>
                                                    <li>парковка (безкоштовно)</li>
                                                    <li>пральня (платно)</li>
                                                    <li>послуги доктора (платно)</li>
                                                    <li>прокат автомобіля (платно)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Опис All Inclusive</th>
                                                <td>
                                                  Готель пропонує харчування по системі<b> All Inclusive:</b>
                                                  <ul>
                                                    <li>сніданок (07: 00-10: 00)</li>
                                                    <li>пізній сніданок(09: 00-10: 00, головний ресторан, шведський стіл)</li>
                                                    <li>обід (13: 00-15: 00)</li>
                                                    <li>вечеря (19: 00-21: 00)</li>
                                                    <li>місцеві алкогольні і безалкогольні напої</li>
                                                  </ul>
                                               </td>
                                              <tr>
                                                <th scope = 'row'> Ресторани і бари</th>
                                                <td>
                                                 <ul>
                                                    <li>головний ресторан (сніданок, обід, вечеря)</li>
                                                    <li>бар на пляжі (10: 00-17: 00; платно)</li>
                                                    <li>бар у бассейна (10:00-22:00)</li>
                                                    <li>кальянная (платно)</li>
                                                  </ul>
                                                  <p>Готель залишає за собою право вносити зміни в розклад роботи барів, кафе, ресторанів.</p>
                                                </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    Власний піщаний, в 3 км від готелю.
                                    <p>Шаттл-бас до пляжу - безкоштовно.</p>
                                    <p>Пляжний інвентар - безкоштовно.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/hotels/egypt/sharm-el/sharm-el-1.jpg' /></p>
                                      <p>Різноманітність видів морських мешканців і сотні коралових рифів Червоного моря роблять Шарм-ель-Шейх особливо привабливим для любителів дайвінгу та еко-туризму. Заснована на туризмі економіка цього міста, розташованого на Синайському півострові, за останні кілька десятиліть пережила значний підйом, що стало причиною виникнення першокласних курортів і розквіту нічного життя.</p>
                                      <p>Серце всього Шарм-ель-Шейха - це Наама-Бей найяскравіший район курорту. Наама-Бей славиться своєю відмінною інфраструктурою. Тут є прогулянкова набережна, казино, безліч ресторанів, барів і кафе, розважальні клуби, нічні дискотеки, екскурсійні бюро та безліч інших закладів.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <b>безкоштовно:</b>
                                              <ul>
                                                <li>відкритий басейн</li>
                                                <li>тренажерний зал</li>
                                              </ul>
                                              <b>За додаткову плату:</b>
                                              <ul>
                                                <li>настільний теніс</li>
                                                <li>SPA-процентним</li>
                                                <li>турецька лазня</li>
                                                <li>сауна</li>
                                                <li>масаж</li>
                                                <li>більярд</li>
                                              </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>дитячий відкритий басейн</li>
                                                <li>дитяче ліжечко (за запитом)</li>
                                                <li>високі стільці в ресторані</li>
                                                <li>дитячі стільці в ресторані</li>
                                              </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в січні</h5>
                                    <p>Погода в січні в Шарм-ель-Шейху суха. Опади вірогідні, але якщо з неба і впадуть краплі, то цього ніхто не помітить. Якщо вдень стовпчик термометра дотягує до + 22 ° C, так само як і тіло акваторії; то після заходу ситуація змінюється. Термометр покаже тільки + 13 ° C. Погода в Шарм-ель-Шейху в січні не дасть розслабитися. Теплі речі Повинні занять почесне місце у валізі. Але нехтувати купальник не варто! У басейнах при готелях температура води незмінно річна. А в безвітряну погоду можна з комфортом поніжитися під сонцем біля моря. Головне пам'ятати, червоний прапор на пляжі - знак заборони на купання.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в лютому</h5>
                                    <p>Під кінець зимового періоду ситуація в Шарм-ель-Шейху мало відрізняється від попередньої їй. Море »подморожена». Його температура чи дотягує до двадцяти градусів за Цельсієм зі знаком плюс. Це погода в Шарм-ель-Шейху в лютому постаралася. Зате, якщо купання НЕ є Наріжним каменем подорожі, можна чудово провести час. В Єгипті чимало пам'ятки, яким НЕ насолодишся в високий сезон і під палючим сонцем. У світлий час доби погода в лютому в Шарм-ель-Шейху нагріє повітря до + 25 ° C в середньому. Після заходу стане в нагоді вітровка, за вікном буде всього + 17 ° C. Серед інших плюсів - відсутність дощів.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в березні</h5>
                                    <p>Поки що на березі комфортно тільки приймати сонячні ванни. Погода в Шрам-ель-Шейху в березні подбала лише про теплі навколо. У воді ж всього + 21 ° C! Зате на березі можна знемагати від спеки, температура повітря часом доходить до + 35 ° C. При таких успіхи, навіть море «відтане» на градус-другий. Середніми ж показниками прогріву повітря стануть + 24 ° C в світлий час доби і + 17 ° C після заходу сонця. Но погода в марте в Шарм-Эль-Шейхе достаточно динамична. И динамика эта положительна. То есть от декады к декаде будет жарче. При этом о дождях можно не беспокоиться, их вероятность сведена к минимуму. Но теплые вещи для вечерних прогулок и на случай сильного ветра (который непременно налетит) взять с собой рекомендуется.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в квітні</h5>
                                    <p>Погода в квітні в Шарм-ель-Шейху непередбачувана в вітро-плані. Так що, побоюватися варто «хамсин». Піщаний вихор налітає раптово, і також несподівано стихає. Теплі речі НЕ знадобляться вже і по ночах, прогретими до + 23 ° C в середньому. Зате довгий рукав або спеціальні засоби врятують від комарів, які можуть докучати відпочиваючим.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в травні</h5>
                                    <p>Погода в Шарм-ель-Шейху в травні Адекватне нікуди. Середньоденний тепло досягає + 34 ° C. З урахуванням кліматичної сухості, відчуття від такого режиму найприємніші. Головне не забувати користуватися кремом від сонця, промені його підступні. Ночами градусник термометра опускається до + 24 ° C. Заспокоюють вітру, а разом з ними і Акваторія, прогріта до + 26 ° C. Маленьким гостям курорту вже НЕ загрожують морські хвилювання. До речі, погода в травні в Шарм-ель-Шейху, кілька підступна. Мінусом штиль стануть комарі, варто подбати про захист.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в червні</h5>
                                    <p>Ось середніх + 37 ° C і до максимальних + 46 ° C - такий градусний розкид очікує біля берега Червоного моря. Погода в Шарм-ель-Шейху в червні все ще милосердна. Низький рівень вологості дозволяє дихати на повні груди, особливо після заходу сонця. Тоді градусник покаже всього + 26 ° C в середньому. А як нагрілося море! + 27 ° C - це коли в воді хочеться проводить годинник. І вся ця сіненебая безхмарність укупі з сухою, але все-таки спекою, може навіть набриднути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в липні</h5>
                                    <p>Погода в Шарм-ель-Шейху в червні дружить з цифрами за сорок. Добре, що в нічні години стовпчик термометра опускається до позначки в + 27 ° C в середньому. Але денні + 40 ° C і більше нікого тут НЕ дивуватися в цей час. Навіщо ж їхати в таке пекло, будучи в равом розумі? Погода в липні в Шарм-ель-Шейху знайшла відповідь. Низька вологість перетворює курорт в подобу сауни з сухою парою - жарко, але добре. Ось сонячного удару застрахує панама, тінь і своєчасну втечу в прохолоду кондиціонованих приміщень (зазвичай з полудня і до п'ятої вечора).</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в серпні</h5>
                                    <p>Обжигающий пісок, сліпуче сонце і соковита зелень навколо - таким буде Серпневий Шарм-ель-Шейх. Середньоденна температура досягає позначки в + 43 ° C! У такі моменти дякуєш винахідника кондиціонерів! Погода в Шарм-ель-Шейху в серпні немов піч. Особливо з полудня і до вечора. Якщо чесно, наслідках і ночами. Після заходу градусник демонструє + 30 ° C. За рахунок сухості клімату, навіть таке пекло терпимо. Акваторія, нагріта до + 29 ° C, завжди допоможе охолонути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в вересні</h5>
                                    <p>Середньоденна температура знижується до + 38 ° C. Погода в Шарм-ель-Шейху в вересні набагато м'якше предидущемесячной. Нічна температура буде дорівнює середнім + 26 ° C. Тільки не потрібно чекати прохолоди в першій же декаді, вона буде скоріше схожа на серпневу ситуацію. Поспішати розлучатися з коштами від сонячних опіків і головних уборів Не варто. Акваторія анітрохи ні остигає, все той же + 29 ° C.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в жовтні</h5>
                                    <p>Погода в Шарм-ель-Шейху в жовтні знає відповідь. Пора в Єгипет! Доказів на користь цього напрямку маса. Море ще тепле, його температура дорівнює + 27 ° C. Турботливі службовці готелю навіть розчищають місцями захід у море від каменів! Залишається тільки насолоджуватися купання в солоній воді. Середньоденна температура досягає + 33 ° C. Вночі цифра змінюється на + 27 ° C. Таким чином, при світлі дня терпимо жарко, а після заходу сонця - саме те. А ще погода в жовтні в Шарм-ель-Шейху екскурсійно-адекватна. Взимку заважають вітру, влітку спека, а міжсезоння прекрасно підійде для знайомства з визначними пам'ятками.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в листопаді</h5>
                                    <p>Погода в Шарм-ель-Шейху в листопаді того підтвердження. Вдень температура тримається на середньому рівні в + 28 ° C. Ночами курорт остигає до + 19 ° C. замерзнути при такому розкладі складно, але можна. Все-таки пустеля колом, і тепла кофта повинна занять почесне місце в багажі (дуже стане в нагоді після заходу). Навіть море ще в тонусі, його тепло одно + 26 ° C, що цілком можна купатися. Погода в листопаді в Шарм-ель-Шейху буває і мокрою. Правда. Сумарна кількість осадом мізерно мало, а тому переживання в сторону.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в грудні</h5>
                                    <p>Погода в Шарм-ель-Шейху в грудні різниться як раз по районному фактора. Проблема в властивих Єгипту зимових вітрах. Старт місяці - це середньоденні + 24 ° C, в цей час і море прогріти до комфортних + 25 ° C, і ночами досить кофтинки тепліше, щоб не змерзнути. У той же час днем ​​- тепло: можна позасмагати в своє задоволення або відправитися на екскурсію. На комфорті більш пізнього перебування позначиться розташування готелю. Ідеалом стане будь-яка з бухт - захищений від вітру пляж - щастя зимових туристів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
               }
           }
           );
            /* Golden Beach Resort(Ex.Movie Gate) 4*/
            tourList.Add(
               new TourVM
           {
               Id = 4,
               Name = "Египт",
               Start = new DateTime(2021, 7, 3, 14, 4, 5),
               End = new DateTime(2021, 7, 10, 18, 5, 5),
               DeparturePlace = "Київ",
               ArivalFromPlace = "Хургада",
               FoodSupplyType = "все включено",
               TravelerTypes = "1 дорослий",
               PeopleCount = 1,
               HotelStars = 4,
               Costs = 11_645,
               Carousel = new Carousel
               {
                   ImgList = new List<CarouselImg>()
                   {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/egypt/golden-beach-resort/0.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/egypt/golden-beach-resort/1.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/egypt/golden-beach-resort/2.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/egypt/golden-beach-resort/3.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/sharm-inn-amarein-4/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/egypt/golden-beach-resort/4.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/golden-beach-resort/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/egypt/golden-beach-resort/5.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/golden-beach-resort/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/egypt/golden-beach-resort/6.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/golden-beach-resort/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 7,
                                Src ="/images/hotels/egypt/golden-beach-resort/7.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/golden-beach-resort/7.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 8,
                                Src ="/images/hotels/egypt/golden-beach-resort/8.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/golden-beach-resort/8.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 9,
                                Src ="/images/hotels/egypt/golden-beach-resort/9.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/golden-beach-resort/9.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 10,
                                Src ="/images/hotels/egypt/golden-beach-resort/10.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/golden-beach-resort/10.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 11,
                                Src ="/images/hotels/egypt/golden-beach-resort/11.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/golden-beach-resort/11.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 12,
                                Src ="/images/hotels/egypt/golden-beach-resort/12.jpg",
                                Alt = "Beldibi",
                                DataRemote= "/images/hotels/egypt/golden-beach-resort/12.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                   },
                   ThumbList = new List<CarouselThumb>()
                   {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/0.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/1.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/2.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/3.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/4.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/5.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/6.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 7,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/7.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 8,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/8.jpg",
                                Alt = "Hurghada",
                            },
                             new CarouselThumb
                            {
                                Id = 9,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/9.jpg",
                                Alt = "Hurghada",
                            },
                             new CarouselThumb
                            {
                                Id = 10,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/10.jpg",
                                Alt = "Hurghada",
                            },
                             new CarouselThumb
                            {
                                Id = 11,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/11.jpg",
                                Alt = "Hurghada",
                            },
                             new CarouselThumb
                            {
                                Id = 12,
                                Src= "/images/hotels/egypt/golden-beach-resort/thumb/12.jpg",
                                Alt = "Hurghada",
                            }
                   }
               },
               Services = new List<TourService>
               {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія"
                        },
               },
               InfoBlocks = new List<TourInfoBlock>
               {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <p>На території готелю розташований пишний Пальмовий сад з безліччю екзотичних дерев. Відмінний вибір для пляжного відпочинку і ідеальний для сімейного. Дайвери оцінять дайвінг-центр, Який є в готелі. У популярному готельному комплексі є басейни і один з крупнейш ...</p>
                                          <table class='table table-striped'>
                                            <tbody>
                                               <tr>
                                                <th scope = 'row'> Розташування </th>
                                                <td>Готель розташований в мальовничому місці на самому березі моря на північний захід від Хургади, в 10 км від Ель Гуни, в 15 км від центру м Хургада і в 20 км від аеропорту.</td>
                                                </tr>
                                              <tr>
                                                <th scope = 'row'>Розміщення</th>
                                                   <td>
                                                     Готельний комплекс складає головної будівлі та кількох прилеглих до нього корпусів. 
                                                     <span>Всього 456 номерів.</span>
                                                     <span>До розміщення пропонуються:<span>
                                                  <ul>
                                                    <li><strong>67 Economy Rooms</strong> 16-24 кв. М, 2 односпальні ліжка або двоспальне ліжко (за запитом), вид на гір і двір, номери без балкона)</li>
                                                    <li><strong>170 Standard Room</strong> (28 кв. М, в односпальні ліжка + диван або двоспальне ліжко (за запитом) + диван, вид на сад і басейн, балкон / тераса</li>
                                                    <li><strong>36 Superior Room</strong> (34 кв. М, 3 стандартні ліжка + диван або двоспальне ліжко + односпальне ліжко + диван, бічний вид на море і басейн, балкон)</li>
                                                    <li><strong>44 Sea View Room</strong> (24 кв. М, 2 односпальні ліжка або двоспальне ліжко (за запитом), вид на море і басейн, балкон)</li>
                                                    <li><strong>13 Connected Rooms</strong> (56 кв. М, 2 стандартних номери із суміжною дверима між ними: 2 односпальні ліжка + диван (1-й номер) і двоспальне ліжко + диван (2-й номер), вид на сад та басейн / 2 ванні кімнати, 2 балкона або 2 тераси)</li>
                                                    <li><strong>14 Family Rooms</strong> (37 кв. М, 3 стандартні ліжка + диван або двоспальне ліжко + односпальне ліжко + диван, вид на гори або двір, номер без балкона)</li>
                                                    <li><strong>92 Deluxe Room</strong> (28 кв. М, 2 односпальні ліжка + диван або двоспальне ліжко (за запитом) + диван, вид на сад і басейн, балкон або тераса</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>ванна кімната</li>
                                                    <li>фен</li>
                                                    <li>кондиціонер</li>
                                                    <li>ТВ</li>
                                                    <li>телефон</li>
                                                    <li>міні-бар</li>
                                                    <li>сейф</li>
                                                 </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Територія </th>
                                                <td>
                                                  <ul>
                                                    <li>Wi-Fi в холі готелю (безкоштовно)</li>
                                                    <li>перукарня (платно)</li>
                                                    <li>пральня (платно)</li>
                                                    <li>послуги доктора (платно)</li>
                                                    <li>амфітеатр</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Опис All Inclusive</th>
                                                <td>
                                                  Готель пропонує харчування по системі<b> All Inclusive:</b>
                                                  <ul>
                                                    <li>сніданок (07: 00-10: 00)</li>
                                                    <li>континентальний сніданок (10: 00-12: 30)</li>
                                                    <li>обід (12: 30-14: 30)</li>
                                                    <li>вечеря (18: 30-21: 00)</li>
                                                    <li>закуски (12: 30-07: 00)</li>
                                                    <li>чай, кава, випічка (15: 30-17: 00)</li>
                                                    <li>місцеві алкогольні і безалкогольні напої</li>
                                                  </ul>
                                                 <p>Готель залишає за собою право вносити зміни в концепцію харчування.</p>
                                               </td>
                                              <tr>
                                                <th scope = 'row'> Ресторани і бари</th>
                                                <td>
                                                <p><strong>Ресторани</strong><p/>
                                                 <ul>
                                                    <li>головний ресторан «INDIANA JONES» (400 місць; інтернаціональна кухня; сніданок, обід, вечеря)</li>
                                                    <li>закусочна «GREASE» (150 місць; сніданок, закуски)</li>
                                                    <li>ресторан a la carte «DON VITO» (150 місць; італійська кухня; 18.30 - 21.30)</li>
                                                    <li>ресторан a la carte «ALADDIN» (80 місць; східна кухня; 18.30 - 21.30)</li>
                                                    <li>ресторан a la carte 'BUFFALO BILL' (200 місць; м'ясні страви; 18.30 - 21.30)</li>
                                                    <li>ресторан a la carte «007» (150 місць; морепродукти; 18.30 - 21.30)</li>
                                                    <li>ресторан a la carte «OCEAN'S 11» (85 місць; 18.30 - 21.30)</li>
                                                  </ul> 
                                                 <p><strong>Бари</strong><p/>
                                                 <ul>
                                                    <li>лобі-бар «RICK'S» (10: 00-00: 00)</li>
                                                    <li>лобі-бар (тільки для дорослих; працює в зимовий сезон, 17: 00-00: 00)</li>
                                                    <li>лобі-бар «CELEBRITIES» (17: 00-00: 00)</li>
                                                    <li>бар на пляжі '007' (10.00 - 18.00 - взимку; 10.00 - 00.00 - влітку)</li>
                                                    <li>кафе «I-SCREAM» (15: 00-18: 00)</li>
                                                    <li>бар біля басейну 'DOLCE VITA' (10: 00-18: 00)</li>
                                                    <li>кафе-бар для підлітків «COYOTE UGLY» (10: 00-18: 00)</li>
                                                    <li>Вітамін бар (10: 00-18: 00; платно)</li>
                                                    <li>диско-бар (після закінчення шоу: 23.00-02.00; напої поза концепції 'Ультра Все Включено'; вхід безкоштовний)</li>
                                                 </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Додаткова інформація</th>
                                                <td>
                                                  <ul>
                                                    <li>Номери для курців і некурящих.</li>
                                                    <li>Місця для куріння на відкритій терасі ресторану.</li>
                                                    <li>кондиціонер</li>
                                                    <li>Деякі заходи будуть проводиться тільки при наявності достатньої кількості учасників.</li>
                                                    <li>В залежності від пори року, Пропоновані заходи можуть бути обмежені через погодні умови.</li>
                                                    <li>В залежності від температури повітря і погодних умов, кондиціонер може бути вимкнений при необхідності.</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    Власний піщаний.
                                    <p>Перша берегова лінія.</p>
                                    <p>Пляжний інвентар - безкоштовно.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/hotels/egypt/sharm-el/hurgada.jpg' /></p>
                                      <p>В Хургаді Ви можете насолодитися дивовижними кораловими рифи і блакитними водами червоного моря, відмінно підходять для віндсерфінгу до того ж прямо біля берега знаходяться чудові місця для дайвінгу та підводного плавання з маскою і трубкою. Хургада розташована неподалік від мальовничих островів Гифтун і Аравійської пустелі. Ми рекомендуємо у вечірний час утриматися від прогулянок невідомамими кварталами за межами готелю. Ви можете оглянути старий квартал Ель-Дахар, а також відвідати порт Marina Hurghada.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <ul>
                                                <li>6 відкритих басейнів (релакс-басейн, басейн для дорослих, окремий дитячий басейн і 2 басейни, з'єднаних штучної рікою)</li>
                                                <li>тренажерний зал</li>
                                                <li>водні гірки</li>
                                                <li>пляжний волейбол</li>
                                                <li>водне поло</li>
                                                <li>настільний тенніс</li>
                                                <li>бадмінтон</li>
                                                <li>дартс</li>
                                                <li>фрісбі</li>
                                                <li>бочче</li>
                                                <li>міні-гольф</li>
                                                <li>шахи</li>
                                                <li>нарди</li>
                                                <li>гігантські шахи</li>
                                                <li>аеробіка</li>
                                                <li>степ-аеробіка</li>
                                                <li>силова аеробіка</li>
                                                <li>аквааеробіка</li>
                                                <li>йога</li>
                                                <li>стретчинг</li>
                                                <li>банан</li>
                                                <li>моторні човни</li>
                                                <li>човен з прозорим дном</li>
                                                <li>дайвінг (екскурсії та курси)</li>
                                                <li>снорклінг (екскурсії)</li>
                                                <li>кайтcерфінг (курси)</li>
                                                <li>віндcерфінг (курси)</li>
                                                <li>кінотеатр і 3D кінотеатр</li>
                                                <li>більярд (платно)</li>
                                              </ul>
                                              <p>* Оренда обладнання, курси, морські прогулянки - платно.</p>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>дитячий відкритий басейн</li>
                                                <li>дитячий міні-клуб (4-12 років)</li>
                                                <li>дитячий майданчик</li>
                                                <li>головоломки</li>
                                                <li>уроки читання</li>
                                                <li>спеціальні програми</li>
                                                <li>дитячий кінотеатр (3D)</li>
                                                <li>вечірній міні-диско</li>
                                                <li>дитяче меню на вечерю</li>
                                                <li>дитячі стільці в ресторані</li>
                                              </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <h5 class='text-secondary'>Погода в Хургаді в січні</h5>
                                    <p>Погода в січні в Шарм-ель-Шейху суха. Опади вірогідні, але якщо з неба і впадуть краплі, то цього ніхто не помітить. Якщо вдень стовпчик термометра дотягує до + 22 ° C, так само як і тіло акваторії; то після заходу ситуація змінюється. Термометр покаже тільки + 13 ° C. Погода в Шарм-ель-Шейху в січні не дасть розслабитися. Теплі речі Повинні занять почесне місце у валізі. Але нехтувати купальник не варто! У басейнах при готелях температура води незмінно річна. А в безвітряну погоду можна з комфортом поніжитися під сонцем біля моря. Головне пам'ятати, червоний прапор на пляжі - знак заборони на купання.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в лютому</h5>
                                    <p>Під кінець зимового періоду ситуація в Шарм-ель-Шейху мало відрізняється від попередньої їй. Море »подморожена». Його температура чи дотягує до двадцяти градусів за Цельсієм зі знаком плюс. Це погода в Шарм-ель-Шейху в лютому постаралася. Зате, якщо купання НЕ є Наріжним каменем подорожі, можна чудово провести час. В Єгипті чимало пам'ятки, яким НЕ насолодишся в високий сезон і під палючим сонцем. У світлий час доби погода в лютому в Шарм-ель-Шейху нагріє повітря до + 25 ° C в середньому. Після заходу стане в нагоді вітровка, за вікном буде всього + 17 ° C. Серед інших плюсів - відсутність дощів.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в березні</h5>
                                    <p>Поки що на березі комфортно тільки приймати сонячні ванни. Погода в Шрам-ель-Шейху в березні подбала лише про теплі навколо. У воді ж всього + 21 ° C! Зате на березі можна знемагати від спеки, температура повітря часом доходить до + 35 ° C. При таких успіхи, навіть море «відтане» на градус-другий. Середніми ж показниками прогріву повітря стануть + 24 ° C в світлий час доби і + 17 ° C після заходу сонця. Но погода в марте в Шарм-Эль-Шейхе достаточно динамична. И динамика эта положительна. То есть от декады к декаде будет жарче. При этом о дождях можно не беспокоиться, их вероятность сведена к минимуму. Но теплые вещи для вечерних прогулок и на случай сильного ветра (который непременно налетит) взять с собой рекомендуется.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в квітні</h5>
                                    <p>Погода в квітні в Шарм-ель-Шейху непередбачувана в вітро-плані. Так що, побоюватися варто «хамсин». Піщаний вихор налітає раптово, і також несподівано стихає. Теплі речі НЕ знадобляться вже і по ночах, прогретими до + 23 ° C в середньому. Зате довгий рукав або спеціальні засоби врятують від комарів, які можуть докучати відпочиваючим.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в травні</h5>
                                    <p>Погода в Шарм-ель-Шейху в травні Адекватне нікуди. Середньоденний тепло досягає + 34 ° C. З урахуванням кліматичної сухості, відчуття від такого режиму найприємніші. Головне не забувати користуватися кремом від сонця, промені його підступні. Ночами градусник термометра опускається до + 24 ° C. Заспокоюють вітру, а разом з ними і Акваторія, прогріта до + 26 ° C. Маленьким гостям курорту вже НЕ загрожують морські хвилювання. До речі, погода в травні в Шарм-ель-Шейху, кілька підступна. Мінусом штиль стануть комарі, варто подбати про захист.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в червні</h5>
                                    <p>Ось середніх + 37 ° C і до максимальних + 46 ° C - такий градусний розкид очікує біля берега Червоного моря. Погода в Шарм-ель-Шейху в червні все ще милосердна. Низький рівень вологості дозволяє дихати на повні груди, особливо після заходу сонця. Тоді градусник покаже всього + 26 ° C в середньому. А як нагрілося море! + 27 ° C - це коли в воді хочеться проводить годинник. І вся ця сіненебая безхмарність укупі з сухою, але все-таки спекою, може навіть набриднути.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в липні</h5>
                                    <p>Погода в Шарм-ель-Шейху в червні дружить з цифрами за сорок. Добре, що в нічні години стовпчик термометра опускається до позначки в + 27 ° C в середньому. Але денні + 40 ° C і більше нікого тут НЕ дивуватися в цей час. Навіщо ж їхати в таке пекло, будучи в равом розумі? Погода в липні в Шарм-ель-Шейху знайшла відповідь. Низька вологість перетворює курорт в подобу сауни з сухою парою - жарко, але добре. Ось сонячного удару застрахує панама, тінь і своєчасну втечу в прохолоду кондиціонованих приміщень (зазвичай з полудня і до п'ятої вечора).</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в серпні</h5>
                                    <p>Обжигающий пісок, сліпуче сонце і соковита зелень навколо - таким буде Серпневий Шарм-ель-Шейх. Середньоденна температура досягає позначки в + 43 ° C! У такі моменти дякуєш винахідника кондиціонерів! Погода в Шарм-ель-Шейху в серпні немов піч. Особливо з полудня і до вечора. Якщо чесно, наслідках і ночами. Після заходу градусник демонструє + 30 ° C. За рахунок сухості клімату, навіть таке пекло терпимо. Акваторія, нагріта до + 29 ° C, завжди допоможе охолонути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в вересні</h5>
                                    <p>Середньоденна температура знижується до + 38 ° C. Погода в Шарм-ель-Шейху в вересні набагато м'якше предидущемесячной. Нічна температура буде дорівнює середнім + 26 ° C. Тільки не потрібно чекати прохолоди в першій же декаді, вона буде скоріше схожа на серпневу ситуацію. Поспішати розлучатися з коштами від сонячних опіків і головних уборів Не варто. Акваторія анітрохи ні остигає, все той же + 29 ° C.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в жовтні</h5>
                                    <p>Погода в Шарм-ель-Шейху в жовтні знає відповідь. Пора в Єгипет! Доказів на користь цього напрямку маса. Море ще тепле, його температура дорівнює + 27 ° C. Турботливі службовці готелю навіть розчищають місцями захід у море від каменів! Залишається тільки насолоджуватися купання в солоній воді. Середньоденна температура досягає + 33 ° C. Вночі цифра змінюється на + 27 ° C. Таким чином, при світлі дня терпимо жарко, а після заходу сонця - саме те. А ще погода в жовтні в Шарм-ель-Шейху екскурсійно-адекватна. Взимку заважають вітру, влітку спека, а міжсезоння прекрасно підійде для знайомства з визначними пам'ятками.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в листопаді</h5>
                                    <p>Погода в Шарм-ель-Шейху в листопаді того підтвердження. Вдень температура тримається на середньому рівні в + 28 ° C. Ночами курорт остигає до + 19 ° C. замерзнути при такому розкладі складно, але можна. Все-таки пустеля колом, і тепла кофта повинна занять почесне місце в багажі (дуже стане в нагоді після заходу). Навіть море ще в тонусі, його тепло одно + 26 ° C, що цілком можна купатися. Погода в листопаді в Шарм-ель-Шейху буває і мокрою. Правда. Сумарна кількість осадом мізерно мало, а тому переживання в сторону.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в грудні</h5>
                                    <p>Погода в Шарм-ель-Шейху в грудні різниться як раз по районному фактора. Проблема в властивих Єгипту зимових вітрах. Старт місяці - це середньоденні + 24 ° C, в цей час і море прогріти до комфортних + 25 ° C, і ночами досить кофтинки тепліше, щоб не змерзнути. У той же час днем ​​- тепло: можна позасмагати в своє задоволення або відправитися на екскурсію. На комфорті більш пізнього перебування позначиться розташування готелю. Ідеалом стане будь-яка з бухт - захищений від вітру пляж - щастя зимових туристів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
               }
           }
           );
            /*IL - mercato - hotel - spa 4*/
            tourList.Add(
               new TourVM
            {
                Id = 5,
                Name = "Египт",
                Start = new DateTime(2021, 7, 3, 14, 4, 5),
                End = new DateTime(2021, 7, 10, 18, 5, 5),
                DeparturePlace = "Київ",
                ArivalFromPlace = "Шарм-Ель-Шейх",
                FoodSupplyType = "все включено",
                TravelerTypes = "1 дорослий",
                PeopleCount = 1,
                HotelStars = 4,
                Costs = 11_645,
                Carousel = new Carousel
                {
                    ImgList = new List<CarouselImg>()
                {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/0.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/1.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/2.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/3.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/4.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/5.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/6.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 7,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/7.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/7.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 8,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/8.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/8.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 9,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/9.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/9.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 10,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/10.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/10.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 11,
                                Src ="/images/hotels/egypt/il-mercato-hotel-spa/11.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/il-mercato-hotel-spa/11.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                     },
                    ThumbList = new List<CarouselThumb>()
                {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/0.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/1.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/2.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/3.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/4.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/5.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/6.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 7,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/7.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 8,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/8.jpg",
                                Alt = "Hurghada",
                            },
                             new CarouselThumb
                            {
                                Id = 9,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/9.jpg",
                                Alt = "Hurghada",
                            },
                             new CarouselThumb
                            {
                                Id = 10,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/10.jpg",
                                Alt = "Hurghada",
                            },
                             new CarouselThumb
                            {
                                Id = 11,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/11.jpg",
                                Alt = "Hurghada",
                            },
                     }
                },
                Services = new List<TourService>
            {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія"
                        },
            },
                InfoBlocks = new List<TourInfoBlock>
            {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <p>Розкішний готель з елегантною архітектурою і просторими стильними номерами розташований поруч зі знаменитою торговою вулицею. До пляжу курсує безкоштовний автобус. До послуг гостей басейни, ресторани і SPA-центр.</p>
                                          <table class='table table-striped'>
                                            <tbody>
                                               <tr>
                                                <th scope = 'row'> Розташування </th>
                                                <td>Готель знаходиться в центрі набережної Іль Меркато, в 5 км від центру міста, в 17 км від аеропорту м Шарм-Ель-Шейх. Загальна площа території готелю - 40000 кв. м. Рік побудови готелю - 2010 р.</td>
                                                </tr>
                                              <tr>
                                                <th scope = 'row'>Розміщення</th>
                                                   <td>
                                                     Готельний комплекс складає головної будівлі до доп. корпусу Анекс, Який знаходиться в 500 м від головної будівлі. 
                                                     <span>Всього 318 номерів.</span>
                                                     <span>До розміщення пропонуються:<span>
                                                  <ul>
                                                    <li><strong>74 Promo Room </strong> 16-24 кв. М, 2 односпальні ліжка або двоспальне ліжко (за запитом), вид на гір і двір, номери без балкона)</li>
                                                    <li><strong>181 Superior Room</strong> (головна будівля, 36 кв. М, з балконом або Андалузії вікном, вид на місто)</li>
                                                    <li><strong>44 Deluxe Room </strong> (головна будівля, 36 кв. М, вид на басейн, номери розташовані близько до всіх об'єктів готелю)</li>
                                                    <li><strong>19 Family Room </strong> (корпус Анекс, 60 кв. М, спальня без дверей, вітальня, номери без балкона)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>ванна кімната</li>
                                                    <li>фен</li>
                                                    <li>кондиціонер</li>
                                                    <li>ТВ</li>
                                                    <li>телефон</li>
                                                    <li>міні-бар</li>
                                                    <li>сейф</li>
                                                 </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Територія </th>
                                                <td>
                                                  <ul>
                                                    <li>Wi-Fi (в лобі, до 150 Mb за весь час перебування і до 2 пристроїв на номер - безкоштовно)</li>
                                                    <li>конференц-зали (платно)</li>
                                                    <li>послуги доктора (платно)</li>
                                                    <li>пральня (платно)</li>
                                                    <li>магазини (платно)</li>
                                                    <li>парковка</li>
                                                    <li>амфітеатр</li>
                                                    <li>обмін валют</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Опис All Inclusive</th>
                                                <td>
                                                  Готель пропонує харчування по системі<b> All Inclusive:</b>
                                                  <ul>
                                                    <li>сніданок (07: 00-10: 00)</li>
                                                    <li>обід (13: 00-15: 00)</li>
                                                    <li>вечеря (18: 30-21: 30)</li>
                                                    <li>закуски (в певні години)</li>
                                                    <li>кава, чай, випічка (16: 00-17: 00)</li>
                                                    <li>місцеві алкогольні і безалкогольні напої</li>
                                                  </ul>
                                                 <p><strong>За додаткову плату: </strong></p>
                                                 <p>Бутильовані напої, свіжовичавлені соки та імпортні алкогольні напої, кальян.</p>
                                                 <p>* Готель залишає за собою право вносить зміни в концепцію харчування.</p>
                                               </td>
                                              <tr>
                                                <th scope = 'row'> Ресторани і бари</th>
                                                <td>
                                                  <ul>
                                                    <li>головний ресторан 'Il Giardino' (сніданок, обід і вечерю - 'шведський стіл')</li>
                                                    <li>ресторані a la carte «La Seppia» (італійська кухня, випічка)</li>
                                                    <li>бар біля басейну 'Terrazina'</li>
                                                    <li>лобі-бар</li>
                                                  </ul> 
                                               </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Послуги для інвалідів</th>
                                                <td>
                                                  <ul>
                                                    <li>Інвалідні крісла (безкоштовно)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Кредитні картки</th>
                                                <td>
                                                  <ul>
                                                    <li>Visa, MasterCard, American Expre</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    <p><strong>1 - Пляж 'Eden Ibiza'.</strong> Розташований в затоці Шарм ель Майя, недалеко від Старого міста, в 1,9 км від готелю. Відвідування - платно. Пляж для плавання з маскою.</p>
                                    <p><strong>2 - Пляж 'Tamra'.</strong> Розташований в 3 км від готелю. Відвідування - платно. Кораловий риф, пляж для плавання з маскою.</p>
                                    <p><strong>3 - Пляж 'Palma'.</strong> Розташований в 2,2 км від готелю. Сервіс харчування і напоїв - безкоштовно. Пляжний інвентар - безкоштовно. Шаттл-бас до пляжу і назад - безкоштовно. Є домашнім риф для плавання з маскою.</p>
                                    <p><strong>Бари на пляжах, крім пляжу 'Palma' - платно.</strong></p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/hotels/egypt/sharm-el/hurgada.jpg' /></p>
                                      <p>В Хургаді Ви можете насолодитися дивовижними кораловими рифи і блакитними водами червоного моря, відмінно підходять для віндсерфінгу до того ж прямо біля берега знаходяться чудові місця для дайвінгу та підводного плавання з маскою і трубкою. Хургада розташована неподалік від мальовничих островів Гифтун і Аравійської пустелі. Ми рекомендуємо у вечірний час утриматися від прогулянок невідомамими кварталами за межами готелю. Ви можете оглянути старий квартал Ель-Дахар, а також відвідати порт Marina Hurghada.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <ul>
                                                <li>4 відкриті басейни (з них 2 з підігрівом взимку)</li>
                                                <li>тренажерний зал</li>
                                                <li>SPA-центр</li>
                                                <li>сауна (платно)</li>
                                                <li>джакузі (платно)</li>
                                                <li>масаж (платно)</li>
                                                <li>більярд (платно)</li>
                                                <li>Пляжний волейбол</li>
                                                <li>водні види спорту на пляжі (платно)</li>
                                               </ul>
                                             </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>дитячий відкритий басейн (секція в дорослому)</li>
                                                <li>дитячий міні-клуб (4-12 років)</li>
                                                <li>дитяча анімація</li>
                                                <li>міні-дискотека</li>
                                                <li>дитяче ліжечко (за запитом)</li>
                                                <li>дитячі стільці в ресторані</li>
                                               </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <h5 class='text-secondary'>Погода в Хургаді в січні</h5>
                                    <p>Погода в січні в Шарм-ель-Шейху суха. Опади вірогідні, але якщо з неба і впадуть краплі, то цього ніхто не помітить. Якщо вдень стовпчик термометра дотягує до + 22 ° C, так само як і тіло акваторії; то після заходу ситуація змінюється. Термометр покаже тільки + 13 ° C. Погода в Шарм-ель-Шейху в січні не дасть розслабитися. Теплі речі Повинні занять почесне місце у валізі. Але нехтувати купальник не варто! У басейнах при готелях температура води незмінно річна. А в безвітряну погоду можна з комфортом поніжитися під сонцем біля моря. Головне пам'ятати, червоний прапор на пляжі - знак заборони на купання.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в лютому</h5>
                                    <p>Під кінець зимового періоду ситуація в Шарм-ель-Шейху мало відрізняється від попередньої їй. Море »подморожена». Його температура чи дотягує до двадцяти градусів за Цельсієм зі знаком плюс. Це погода в Шарм-ель-Шейху в лютому постаралася. Зате, якщо купання НЕ є Наріжним каменем подорожі, можна чудово провести час. В Єгипті чимало пам'ятки, яким НЕ насолодишся в високий сезон і під палючим сонцем. У світлий час доби погода в лютому в Шарм-ель-Шейху нагріє повітря до + 25 ° C в середньому. Після заходу стане в нагоді вітровка, за вікном буде всього + 17 ° C. Серед інших плюсів - відсутність дощів.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в березні</h5>
                                    <p>Поки що на березі комфортно тільки приймати сонячні ванни. Погода в Шрам-ель-Шейху в березні подбала лише про теплі навколо. У воді ж всього + 21 ° C! Зате на березі можна знемагати від спеки, температура повітря часом доходить до + 35 ° C. При таких успіхи, навіть море «відтане» на градус-другий. Середніми ж показниками прогріву повітря стануть + 24 ° C в світлий час доби і + 17 ° C після заходу сонця. Но погода в марте в Шарм-Эль-Шейхе достаточно динамична. И динамика эта положительна. То есть от декады к декаде будет жарче. При этом о дождях можно не беспокоиться, их вероятность сведена к минимуму. Но теплые вещи для вечерних прогулок и на случай сильного ветра (который непременно налетит) взять с собой рекомендуется.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в квітні</h5>
                                    <p>Погода в квітні в Шарм-ель-Шейху непередбачувана в вітро-плані. Так що, побоюватися варто «хамсин». Піщаний вихор налітає раптово, і також несподівано стихає. Теплі речі НЕ знадобляться вже і по ночах, прогретими до + 23 ° C в середньому. Зате довгий рукав або спеціальні засоби врятують від комарів, які можуть докучати відпочиваючим.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в травні</h5>
                                    <p>Погода в Шарм-ель-Шейху в травні Адекватне нікуди. Середньоденний тепло досягає + 34 ° C. З урахуванням кліматичної сухості, відчуття від такого режиму найприємніші. Головне не забувати користуватися кремом від сонця, промені його підступні. Ночами градусник термометра опускається до + 24 ° C. Заспокоюють вітру, а разом з ними і Акваторія, прогріта до + 26 ° C. Маленьким гостям курорту вже НЕ загрожують морські хвилювання. До речі, погода в травні в Шарм-ель-Шейху, кілька підступна. Мінусом штиль стануть комарі, варто подбати про захист.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в червні</h5>
                                    <p>Ось середніх + 37 ° C і до максимальних + 46 ° C - такий градусний розкид очікує біля берега Червоного моря. Погода в Шарм-ель-Шейху в червні все ще милосердна. Низький рівень вологості дозволяє дихати на повні груди, особливо після заходу сонця. Тоді градусник покаже всього + 26 ° C в середньому. А як нагрілося море! + 27 ° C - це коли в воді хочеться проводить годинник. І вся ця сіненебая безхмарність укупі з сухою, але все-таки спекою, може навіть набриднути.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в липні</h5>
                                    <p>Погода в Шарм-ель-Шейху в червні дружить з цифрами за сорок. Добре, що в нічні години стовпчик термометра опускається до позначки в + 27 ° C в середньому. Але денні + 40 ° C і більше нікого тут НЕ дивуватися в цей час. Навіщо ж їхати в таке пекло, будучи в равом розумі? Погода в липні в Шарм-ель-Шейху знайшла відповідь. Низька вологість перетворює курорт в подобу сауни з сухою парою - жарко, але добре. Ось сонячного удару застрахує панама, тінь і своєчасну втечу в прохолоду кондиціонованих приміщень (зазвичай з полудня і до п'ятої вечора).</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в серпні</h5>
                                    <p>Обжигающий пісок, сліпуче сонце і соковита зелень навколо - таким буде Серпневий Шарм-ель-Шейх. Середньоденна температура досягає позначки в + 43 ° C! У такі моменти дякуєш винахідника кондиціонерів! Погода в Шарм-ель-Шейху в серпні немов піч. Особливо з полудня і до вечора. Якщо чесно, наслідках і ночами. Після заходу градусник демонструє + 30 ° C. За рахунок сухості клімату, навіть таке пекло терпимо. Акваторія, нагріта до + 29 ° C, завжди допоможе охолонути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в вересні</h5>
                                    <p>Середньоденна температура знижується до + 38 ° C. Погода в Шарм-ель-Шейху в вересні набагато м'якше предидущемесячной. Нічна температура буде дорівнює середнім + 26 ° C. Тільки не потрібно чекати прохолоди в першій же декаді, вона буде скоріше схожа на серпневу ситуацію. Поспішати розлучатися з коштами від сонячних опіків і головних уборів Не варто. Акваторія анітрохи ні остигає, все той же + 29 ° C.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в жовтні</h5>
                                    <p>Погода в Шарм-ель-Шейху в жовтні знає відповідь. Пора в Єгипет! Доказів на користь цього напрямку маса. Море ще тепле, його температура дорівнює + 27 ° C. Турботливі службовці готелю навіть розчищають місцями захід у море від каменів! Залишається тільки насолоджуватися купання в солоній воді. Середньоденна температура досягає + 33 ° C. Вночі цифра змінюється на + 27 ° C. Таким чином, при світлі дня терпимо жарко, а після заходу сонця - саме те. А ще погода в жовтні в Шарм-ель-Шейху екскурсійно-адекватна. Взимку заважають вітру, влітку спека, а міжсезоння прекрасно підійде для знайомства з визначними пам'ятками.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в листопаді</h5>
                                    <p>Погода в Шарм-ель-Шейху в листопаді того підтвердження. Вдень температура тримається на середньому рівні в + 28 ° C. Ночами курорт остигає до + 19 ° C. замерзнути при такому розкладі складно, але можна. Все-таки пустеля колом, і тепла кофта повинна занять почесне місце в багажі (дуже стане в нагоді після заходу). Навіть море ще в тонусі, його тепло одно + 26 ° C, що цілком можна купатися. Погода в листопаді в Шарм-ель-Шейху буває і мокрою. Правда. Сумарна кількість осадом мізерно мало, а тому переживання в сторону.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в грудні</h5>
                                    <p>Погода в Шарм-ель-Шейху в грудні різниться як раз по районному фактора. Проблема в властивих Єгипту зимових вітрах. Старт місяці - це середньоденні + 24 ° C, в цей час і море прогріти до комфортних + 25 ° C, і ночами досить кофтинки тепліше, щоб не змерзнути. У той же час днем ​​- тепло: можна позасмагати в своє задоволення або відправитися на екскурсію. На комфорті більш пізнього перебування позначиться розташування готелю. Ідеалом стане будь-яка з бухт - захищений від вітру пляж - щастя зимових туристів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
            }
            }
           );
            /*le - pacha - resort - 4*/
            tourList.Add(
               new TourVM
          {
              Id = 6,
              Name = "Египт",
              Start = new DateTime(2021, 7, 3, 14, 4, 5),
              End = new DateTime(2021, 7, 10, 18, 5, 5),
              DeparturePlace = "Київ",
              ArivalFromPlace = "Хургада",
              FoodSupplyType = "все включено",
              TravelerTypes = "1 дорослий",
              PeopleCount = 1,
              HotelStars = 4,
              Costs = 11_645,
              Carousel = new Carousel
              {
                  ImgList = new List<CarouselImg>()
              {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/egypt/le-pacha-resort-4/0.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/le-pacha-resort-4/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/egypt/le-pacha-resort-4/1.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/le-pacha-resort-4/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/egypt/le-pacha-resort-4/2.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/le-pacha-resort-4/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/egypt/le-pacha-resort-4/3.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/le-pacha-resort-4/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/egypt/le-pacha-resort-4/4.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/le-pacha-resort-4/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/egypt/le-pacha-resort-4/5.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/le-pacha-resort-4/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/egypt/le-pacha-resort-4/6.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/le-pacha-resort-4/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                  },
                  ThumbList = new List<CarouselThumb>()
              {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/egypt/le-pacha-resort-4/thumb/0.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/egypt/le-pacha-resort-4/thumb/1.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/egypt/le-pacha-resort-4/thumb/2.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/egypt/le-pacha-resort-4/thumb/3.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/4.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/5.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/egypt/il-mercato-hotel-spa/thumb/6.jpg",
                                Alt = "Hurghada",
                            },
                  }
              },
              Services = new List<TourService>
          {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія)"
                        },
          },
              InfoBlocks = new List<TourInfoBlock>
          {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <p>Основний 3-х поверховий корпус готелю оточений десятьма 2-поверховими котеджами, розташованими поруч з піщаним пляжем. Готель пропонує відмінний відпочинок за системою 'се включено' в центральній частині Хургади.</p>
                                          <table class='table table-striped'>
                                            <tbody>
                                               <tr>
                                                <th scope = 'row'> Розташування </th>
                                                <td>Готель розташований в головному триповерховому будинку і десяти двоповерхових корпусах.</td>
                                                </tr>
                                              <tr>
                                                <th scope = 'row'>Розміщення</th>
                                                   <td>
                                                     Готель розташований в головному триповерховому будинку і десяти двоповерхових корпусах.
                                                     <span>Всього - 258 номерів.</span>
                                                     <span>До розміщення пропонуються:<span>
                                                  <ul>
                                                    <li><strong>Standard Rooms</strong> (окремий балкон з зоною відпочинку, два односпальні або одне двоспальне ліжко)</li>
                                                    <li><strong>Junior Suite</strong> (вид на Червоне море і окремий балкон, ліжко 'king-size', вітальня і обідня зона з кріслами)</li>
                                                    <li><strong>Family Rooms</strong> (вид на море. Складається з двох ОКРЕМИХ спалень, вітальні і двох туалетів)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>міні-бар</li>
                                                    <li>шафа</li>
                                                    <li>кондиціонер</li>
                                                    <li>ТВ</li>
                                                    <li>телефон</li>
                                                    <li>міні-бар</li>
                                                    <li>сейф</li>
                                                    <li>обслуговуванням номерів (цілодобово)</li
                                                    <li>фен</li>
                                                    <li>ванна або душ</li>
                                                    <li>зміна постільної білизни (2-3 рази на тиждень)</li>
                                                    <li>прибирання номера (щодня)</li>
                                                    <li>міні-бар (платно)</li>
                                                    <li>тераса / балкон</li>
                                                 </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Територія</th>
                                                <td>
                                                  <ul>
                                                    <li>Wi-Fi (в лобі, до 150 Mb за весь час перебування і до 2 пристроїв на номер - безкоштовно)</li>
                                                    <li>пральня (платно)</li>
                                                    <li>обмін валюти</li>
                                                    <li>Wi-Fi (в лобі)</li>
                                                    <li>магазини (платно)</li>
                                                    <li>інтернет-салон (платно)</li>
                                                    <li>салон краси (платно)</li>
                                                    <li>торгова галерея / торговий центр</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Опис All Inclusive</th>
                                                <td>
                                                  Готель пропонує харчування по системі<b> All Inclusive:</b>
                                                  <ul>
                                                    <li>сніданок (07: 00-10: 00)</li>
                                                    <li>обід (13: 00-15: 00)</li>
                                                    <li>вечеря (18: 30-21: 30)</li>
                                                  </ul>
                                                 <p>У денні години для гостей: чай / кава, випічка - з 16: 00-17: 00.</p>
                                                 <p>Морозиво для дітей - з 16: 00-17: 00.</p>
                                                 <p>Місцеві алкогольні та безалкогольні напої в ресторані і барах готелях, включених в систему 'все включено' - безкоштовно протягом дня (в лобі-барі напої доступні для гостей 24г.).</p>
                                                 <p><strong>За додаткову плату:</strong></p>
                                                 <p>Iмпортні напої, бутильовані напої, свіжовичавлені соки, ресторани a la carte</p>
                                                 <p>Готель залишає за собою право вносити зміни в програму 'все включено'</p>
                                               </td>
                                              <tr>
                                                <th scope = 'row'>Ресторани і бари</th>
                                                <td>
                                                  <p><b>Головний ресторан</b></p>
                                                  <p>Ресторани A la Carte (платно; за попередньою Резервація):</p>
                                                  <ul>
                                                    <li>китайський ресторан</li>
                                                    <li>італійський ресторан</li>
                                                  </ul>
                                                    <p><b>Головний ресторан</b></p>
                                                  <p><b>Бари:</b></p>
                                                  <ul>
                                                    <li>бар на пляжі 10: 00-18: 00 (до 17:00 в зимовий час)</li>
                                                    <li>бар біля басейну 10: 00-18: 00 (до 17:00 в зимовий час)</li>
                                                    <li>лобі-бар (цілодобово).</li>
                                                    <li>диско-бар (напої - платно, 23: 00-04: 00)</li>
                                                    <li>кафе (платно)</li>
                                                  </ul> 
                                               </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Послуги для інвалідів</th>
                                                <td>
                                                  <ul>
                                                    <li>Інвалідні крісла (платно)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    <p>Приватний піщаний пляж.</p>
                                    <p>Рекомендується спеціальне взуття для входу в море.</p>
                                    <p><strong>Пляжні рушники, парасольки і шезлонги надаються безкоштовно.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/hotels/egypt/sharm-el/hurgada.jpg' /></p>
                                      <p>В Хургаді Ви можете насолодитися дивовижними кораловими рифи і блакитними водами червоного моря, відмінно підходять для віндсерфінгу до того ж прямо біля берега знаходяться чудові місця для дайвінгу та підводного плавання з маскою і трубкою. Хургада розташована неподалік від мальовничих островів Гифтун і Аравійської пустелі. Ми рекомендуємо у вечірний час утриматися від прогулянок невідомамими кварталами за межами готелю. Ви можете оглянути старий квартал Ель-Дахар, а також відвідати порт Marina Hurghada.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <ul>
                                                <li>відкритий басейн (з прісною водою, без підігріву)</li>
                                                <li>SPA-центр (платно, сауна, джакузі, масаж)</li>
                                                <li>масаж (платно)</li>
                                                <li>джакузі (платно), сауна (платно)</li>
                                                <li>тренажерний зал (платно)</li>
                                                <li>більярд (платно)</li>
                                                <li>водне поло</li>
                                                <li>настільний теніс</li>
                                                <li>пляжний волейбол</li>
                                                <li>водні види спорту (платно)</li>
                                                <li>дайвінг (платно)</li>
                                                <li>дискотека</li>
                                                <li>жива музика</li>
                                              </ul>
                                             </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>дитячий басейн (з прісною водою, без підігріву)</li>
                                                <li>дитячий міні-клуб</li>
                                                <li>дитяче меню (страви на шведському столі)</li>
                                                <li>дитяча анімація</li>
                                                <li>дитячий майданчик</li>
                                                <li>дитяче ліжечко (за запитом)</li>
                                                <li>дитячі стільці в ресторані</li>
                                               </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <h5 class='text-secondary'>Погода в Хургаді в січні</h5>
                                    <p>Погода в січні в Хургаді суха. Опади вірогідні, але якщо з неба і впадуть краплі, то цього ніхто не помітить. Якщо вдень стовпчик термометра дотягує до + 22 ° C, так само як і тіло акваторії; то після заходу ситуація змінюється. Термометр покаже тільки + 13 ° C. Погода в Хургаді в січні не дасть розслабитися. Теплі речі Повинні занять почесне місце у валізі. Але нехтувати купальник не варто! У басейнах при готелях температура води незмінно річна. А в безвітряну погоду можна з комфортом поніжитися під сонцем біля моря. Головне пам'ятати, червоний прапор на пляжі - знак заборони на купання.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в лютому</h5>
                                    <p>Під кінець зимового періоду ситуація в Хургаді мало відрізняється від попередньої їй. Море »подморожена». Його температура чи дотягує до двадцяти градусів за Цельсієм зі знаком плюс. Це погода в Хургаді в лютому постаралася. Зате, якщо купання НЕ є Наріжним каменем подорожі, можна чудово провести час. В Єгипті чимало пам'ятки, яким НЕ насолодишся в високий сезон і під палючим сонцем. У світлий час доби погода в лютому в Хургаді нагріє повітря до + 25 ° C в середньому. Після заходу стане в нагоді вітровка, за вікном буде всього + 17 ° C. Серед інших плюсів - відсутність дощів.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в березні</h5>
                                    <p>Поки що на березі комфортно тільки приймати сонячні ванни. Погода в Шрам-ель-Шейху в березні подбала лише про теплі навколо. У воді ж всього + 21 ° C! Зате на березі можна знемагати від спеки, температура повітря часом доходить до + 35 ° C. При таких успіхи, навіть море «відтане» на градус-другий. Середніми ж показниками прогріву повітря стануть + 24 ° C в світлий час доби і + 17 ° C після заходу сонця. Но погода в марте в Шарм-Эль-Шейхе достаточно динамична. И динамика эта положительна. То есть от декады к декаде будет жарче. При этом о дождях можно не беспокоиться, их вероятность сведена к минимуму. Но теплые вещи для вечерних прогулок и на случай сильного ветра (который непременно налетит) взять с собой рекомендуется.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в квітні</h5>
                                    <p>Погода в квітні в Хургаді непередбачувана в вітро-плані. Так що, побоюватися варто «хамсин». Піщаний вихор налітає раптово, і також несподівано стихає. Теплі речі НЕ знадобляться вже і по ночах, прогретими до + 23 ° C в середньому. Зате довгий рукав або спеціальні засоби врятують від комарів, які можуть докучати відпочиваючим.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в травні</h5>
                                    <p>Погода в Хургаді в травні Адекватне нікуди. Середньоденний тепло досягає + 34 ° C. З урахуванням кліматичної сухості, відчуття від такого режиму найприємніші. Головне не забувати користуватися кремом від сонця, промені його підступні. Ночами градусник термометра опускається до + 24 ° C. Заспокоюють вітру, а разом з ними і Акваторія, прогріта до + 26 ° C. Маленьким гостям курорту вже НЕ загрожують морські хвилювання. До речі, погода в травні в Хургаді, кілька підступна. Мінусом штиль стануть комарі, варто подбати про захист.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в червні</h5>
                                    <p>Ось середніх + 37 ° C і до максимальних + 46 ° C - такий градусний розкид очікує біля берега Червоного моря. Погода в Хургаді в червні все ще милосердна. Низький рівень вологості дозволяє дихати на повні груди, особливо після заходу сонця. Тоді градусник покаже всього + 26 ° C в середньому. А як нагрілося море! + 27 ° C - це коли в воді хочеться проводить годинник. І вся ця сіненебая безхмарність укупі з сухою, але все-таки спекою, може навіть набриднути.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в липні</h5>
                                    <p>Погода в Хургаді в червні дружить з цифрами за сорок. Добре, що в нічні години стовпчик термометра опускається до позначки в + 27 ° C в середньому. Але денні + 40 ° C і більше нікого тут НЕ дивуватися в цей час. Навіщо ж їхати в таке пекло, будучи в равом розумі? Погода в липні в Хургаді знайшла відповідь. Низька вологість перетворює курорт в подобу сауни з сухою парою - жарко, але добре. Ось сонячного удару застрахує панама, тінь і своєчасну втечу в прохолоду кондиціонованих приміщень (зазвичай з полудня і до п'ятої вечора).</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в серпні</h5>
                                    <p>Обжигающий пісок, сліпуче сонце і соковита зелень навколо - таким буде Серпневий Шарм-ель-Шейх. Середньоденна температура досягає позначки в + 43 ° C! У такі моменти дякуєш винахідника кондиціонерів! Погода в Хургаді в серпні немов піч. Особливо з полудня і до вечора. Якщо чесно, наслідках і ночами. Після заходу градусник демонструє + 30 ° C. За рахунок сухості клімату, навіть таке пекло терпимо. Акваторія, нагріта до + 29 ° C, завжди допоможе охолонути.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в вересні</h5>
                                    <p>Середньоденна температура знижується до + 38 ° C. Погода в Хургаді в вересні набагато м'якше предидущемесячной. Нічна температура буде дорівнює середнім + 26 ° C. Тільки не потрібно чекати прохолоди в першій же декаді, вона буде скоріше схожа на серпневу ситуацію. Поспішати розлучатися з коштами від сонячних опіків і головних уборів Не варто. Акваторія анітрохи ні остигає, все той же + 29 ° C.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в жовтні</h5>
                                    <p>Погода в Хургаді в жовтні знає відповідь. Пора в Єгипет! Доказів на користь цього напрямку маса. Море ще тепле, його температура дорівнює + 27 ° C. Турботливі службовці готелю навіть розчищають місцями захід у море від каменів! Залишається тільки насолоджуватися купання в солоній воді. Середньоденна температура досягає + 33 ° C. Вночі цифра змінюється на + 27 ° C. Таким чином, при світлі дня терпимо жарко, а після заходу сонця - саме те. А ще погода в жовтні в Хургаді екскурсійно-адекватна. Взимку заважають вітру, влітку спека, а міжсезоння прекрасно підійде для знайомства з визначними пам'ятками.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в листопаді</h5>
                                    <p>Погода в Хургаді в листопаді того підтвердження. Вдень температура тримається на середньому рівні в + 28 ° C. Ночами курорт остигає до + 19 ° C. замерзнути при такому розкладі складно, але можна. Все-таки пустеля колом, і тепла кофта повинна занять почесне місце в багажі (дуже стане в нагоді після заходу). Навіть море ще в тонусі, його тепло одно + 26 ° C, що цілком можна купатися. Погода в листопаді в Хургаді буває і мокрою. Правда. Сумарна кількість осадом мізерно мало, а тому переживання в сторону.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді в грудні</h5>
                                    <p>Погода в Хургаді в грудні різниться як раз по районному фактора. Проблема в властивих Єгипту зимових вітрах. Старт місяці - це середньоденні + 24 ° C, в цей час і море прогріти до комфортних + 25 ° C, і ночами досить кофтинки тепліше, щоб не змерзнути. У той же час днем ​​- тепло: можна позасмагати в своє задоволення або відправитися на екскурсію. На комфорті більш пізнього перебування позначиться розташування готелю. Ідеалом стане будь-яка з бухт - захищений від вітру пляж - щастя зимових туристів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
          }
          }
           );
            /* falcon - hills - hotel - 3*/
            tourList.Add(
               new TourVM
              {
                  Id = 7,
                  Name = "Египт",
                  Start = new DateTime(2021, 7, 3, 14, 4, 5),
                  End = new DateTime(2021, 7, 10, 18, 5, 5),
                  DeparturePlace = "Київ",
                  ArivalFromPlace = "Шарм-Ель-Шейх",
                  FoodSupplyType = "все включено",
                  TravelerTypes = "1 дорослий",
                  PeopleCount = 1,
                  HotelStars = 3,
                  Costs = 11_645,
                  Carousel = new Carousel
                  {
                      ImgList = new List<CarouselImg>()
               {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/egypt/falcon-hills-hotel-3/0.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/falcon-hills-hotel-3/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/egypt/falcon-hills-hotel-3/1.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/falcon-hills-hotel-3/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/egypt/falcon-hills-hotel-3/2.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/falcon-hills-hotel-3/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/egypt/falcon-hills-hotel-3/3.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/falcon-hills-hotel-3/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/egypt/falcon-hills-hotel-3/4.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/falcon-hills-hotel-3/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/egypt/falcon-hills-hotel-3/5.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/falcon-hills-hotel-3/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/egypt/falcon-hills-hotel-3/6.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/falcon-hills-hotel-3/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 7,
                                Src ="/images/hotels/egypt/falcon-hills-hotel-3/7.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/falcon-hills-hotel-3/7.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 8,
                                Src ="/images/hotels/egypt/falcon-hills-hotel-3/8.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/falcon-hills-hotel-3/8.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 9,
                                Src ="/images/hotels/egypt/falcon-hills-hotel-3/9.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/falcon-hills-hotel-3/9.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                      },
                      ThumbList = new List<CarouselThumb>()
               {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/egypt/falcon-hills-hotel-3/thumb/0.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/egypt/falcon-hills-hotel-3/thumb/1.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/egypt/falcon-hills-hotel-3/thumb/2.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/egypt/falcon-hills-hotel-3/thumb/3.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/egypt/falcon-hills-hotel-3/thumb/4.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/egypt/falcon-hills-hotel-3/thumb/5.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/egypt/falcon-hills-hotel-3/thumb/6.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 7,
                                Src= "/images/hotels/egypt/falcon-hills-hotel-3/thumb/7.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 8,
                                Src= "/images/hotels/egypt/falcon-hills-hotel-3/thumb/8.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                             new CarouselThumb
                            {
                                Id = 9,
                                Src= "/images/hotels/egypt/falcon-hills-hotel-3/thumb/9.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                      }
                  },
                  Services = new List<TourService>
           {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія"
                        },
           },
                  InfoBlocks = new List<TourInfoBlock>
           {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <p>На території готелю 2 басейни, фітнес-центр. Різноманітні системи харчування, в тому числі «Все включено». На піщаний пляж Terrazzina гостей доставляє безкоштовний автобус.</p>
                                          <table class='table table-striped'>
                                            <tbody>
                                               <tr>
                                                <th scope = 'row'>Розташування</th>
                                                <td>Готель знаходиться в 17 км від аеропорту, в 5 км від курортного центру Шарм-ель-Шейха.</td>
                                                </tr>
                                              <tr>
                                                <th scope = 'row'>Розміщення</th>
                                                   <td>
                                                     <span>Всього 113 номерів.</span>
                                                     <span>До розміщення пропонуються:<span>
                                                  <ul>
                                                    <li><strong>Standard Pool View</strong> (20 кв. М, номери на 1-му поверсі готелю, вид на басейн)</li>
                                                    <li><strong>Standard Garden View</strong> (20 кв. М, номери на 1-му поверсі готелю, вид на сад)</li>
                                                    <li><strong>Suite</strong> (60 кв. М, вітальня, спальня без дверей)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>ванна кімната</li>
                                                    <li>кондиціонер</li>
                                                    <li>ТВ</li>
                                                    <li>телефон</li>
                                                    <li>міні-бар (платно)</li>
                                                    <li>тераса / балкон (10 номерів без балкона)</li>
                                                    <li>прибирання номера (щодня)</li>
                                                    <li>зміна постільної білизни (щодня)</li>
                                                    <li>сервіс в номер (за додаткову плату)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Територія</th>
                                                <td>
                                                  <ul>
                                                    <li>Wi-Fi в лобі (безкоштовно)</li>
                                                    <li>пральня (платно)</li>
                                                    <li>парковка</li>
                                                    <li>прокат автомобіля (платно)</li>
                                                    <li>послуги доктора (платно)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Опис All Inclusive</th>
                                                <td>
                                                  Готель пропонує харчування по системі<b> All Inclusive:</b>
                                                  <ul>
                                                    <li>сніданок, обід, вечеря - шведський стіл</li>
                                                    <li>місцеві алкогольні і безалкогольні напої</li>
                                                  </ul>
                                               <p>* Готель залишає за собою право вносить зміни в концепцію харчування.</p>
                                               </td>
                                              <tr>
                                                <th scope = 'row'>Ресторани і бари</th>
                                                <td>
                                                  <ul>
                                                    <li>головний ресторан</li>
                                                    <li>бар на пляжі</li>
                                                    <li>бар біля басейну</li>
                                                    <li>лобі-бар</li>
                                                  </ul> 
                                               </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    <p>Власний піщаний.</p>
                                    <p>Шаттл-бас до пляжу - надається.</p>
                                    <p><strong>Пляжний інвентар - безкоштовно.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/hotels/egypt/sharm-el/sharm-el-1.jpg' /></p>
                                      <p>Різноманітність видів морських мешканців і сотні коралових рифів Червоного моря роблять Шарм-ель-Шейх особливо привабливим для любителів дайвінгу та еко-туризму. Заснована на туризмі економіка цього міста, розташованого на Синайському півострові, за останні кілька десятиліть пережила значний підйом, що стало причиною виникнення першокласних курортів і розквіту нічного життя.</p>
                                      <p>Серце всього Шарм-ель-Шейха - це Наама-Бей найяскравіший район курорту. Наама-Бей славиться своєю відмінною інфраструктурою. Тут є прогулянкова набережна, казино, безліч ресторанів, барів і кафе, розважальні клуби, нічні дискотеки, екскурсійні бюро та безліч інших закладів.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <ul>
                                                <li>4 відкриті басейни (з них 2 з підігрівом взимку)</li>
                                                <li>тренажерний зал</li>
                                                <li>SPA-центр</li>
                                                <li>сауна (платно)</li>
                                                <li>джакузі (платно)</li>
                                                <li>масаж (платно)</li>
                                                <li>більярд (платно)</li>
                                                <li>Пляжний волейбол</li>
                                                <li>водні види спорту на пляжі (платно)</li>
                                               </ul>
                                             </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>дитячий відкритий басейн (секція в дорослому)</li>
                                                <li>дитячий міні-клуб (4-12 років)</li>
                                                <li>дитяча анімація</li>
                                                <li>міні-дискотека</li>
                                                <li>дитяче ліжечко (за запитом)</li>
                                                <li>дитячі стільці в ресторані</li>
                                               </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в січні</h5>
                                    <p>Погода в січні в Шарм-ель-Шейху суха. Опади вірогідні, але якщо з неба і впадуть краплі, то цього ніхто не помітить. Якщо вдень стовпчик термометра дотягує до + 22 ° C, так само як і тіло акваторії; то після заходу ситуація змінюється. Термометр покаже тільки + 13 ° C. Погода в Шарм-ель-Шейху в січні не дасть розслабитися. Теплі речі Повинні занять почесне місце у валізі. Але нехтувати купальник не варто! У басейнах при готелях температура води незмінно річна. А в безвітряну погоду можна з комфортом поніжитися під сонцем біля моря. Головне пам'ятати, червоний прапор на пляжі - знак заборони на купання.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в лютому</h5>
                                    <p>Під кінець зимового періоду ситуація в Шарм-ель-Шейху мало відрізняється від попередньої їй. Море »подморожена». Його температура чи дотягує до двадцяти градусів за Цельсієм зі знаком плюс. Це погода в Шарм-ель-Шейху в лютому постаралася. Зате, якщо купання НЕ є Наріжним каменем подорожі, можна чудово провести час. В Єгипті чимало пам'ятки, яким НЕ насолодишся в високий сезон і під палючим сонцем. У світлий час доби погода в лютому в Шарм-ель-Шейху нагріє повітря до + 25 ° C в середньому. Після заходу стане в нагоді вітровка, за вікном буде всього + 17 ° C. Серед інших плюсів - відсутність дощів.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в березні</h5>
                                    <p>Поки що на березі комфортно тільки приймати сонячні ванни. Погода в Шрам-ель-Шейху в березні подбала лише про теплі навколо. У воді ж всього + 21 ° C! Зате на березі можна знемагати від спеки, температура повітря часом доходить до + 35 ° C. При таких успіхи, навіть море «відтане» на градус-другий. Середніми ж показниками прогріву повітря стануть + 24 ° C в світлий час доби і + 17 ° C після заходу сонця. Но погода в марте в Шарм-Эль-Шейхе достаточно динамична. И динамика эта положительна. То есть от декады к декаде будет жарче. При этом о дождях можно не беспокоиться, их вероятность сведена к минимуму. Но теплые вещи для вечерних прогулок и на случай сильного ветра (который непременно налетит) взять с собой рекомендуется.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в квітні</h5>
                                    <p>Погода в квітні в Шарм-ель-Шейху непередбачувана в вітро-плані. Так що, побоюватися варто «хамсин». Піщаний вихор налітає раптово, і також несподівано стихає. Теплі речі НЕ знадобляться вже і по ночах, прогретими до + 23 ° C в середньому. Зате довгий рукав або спеціальні засоби врятують від комарів, які можуть докучати відпочиваючим.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в травні</h5>
                                    <p>Погода в Шарм-ель-Шейху в травні Адекватне нікуди. Середньоденний тепло досягає + 34 ° C. З урахуванням кліматичної сухості, відчуття від такого режиму найприємніші. Головне не забувати користуватися кремом від сонця, промені його підступні. Ночами градусник термометра опускається до + 24 ° C. Заспокоюють вітру, а разом з ними і Акваторія, прогріта до + 26 ° C. Маленьким гостям курорту вже НЕ загрожують морські хвилювання. До речі, погода в травні в Шарм-ель-Шейху, кілька підступна. Мінусом штиль стануть комарі, варто подбати про захист.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в червні</h5>
                                    <p>Ось середніх + 37 ° C і до максимальних + 46 ° C - такий градусний розкид очікує біля берега Червоного моря. Погода в Шарм-ель-Шейху в червні все ще милосердна. Низький рівень вологості дозволяє дихати на повні груди, особливо після заходу сонця. Тоді градусник покаже всього + 26 ° C в середньому. А як нагрілося море! + 27 ° C - це коли в воді хочеться проводить годинник. І вся ця сіненебая безхмарність укупі з сухою, але все-таки спекою, може навіть набриднути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в липні</h5>
                                    <p>Погода в Шарм-ель-Шейху в червні дружить з цифрами за сорок. Добре, що в нічні години стовпчик термометра опускається до позначки в + 27 ° C в середньому. Але денні + 40 ° C і більше нікого тут НЕ дивуватися в цей час. Навіщо ж їхати в таке пекло, будучи в равом розумі? Погода в липні в Шарм-ель-Шейху знайшла відповідь. Низька вологість перетворює курорт в подобу сауни з сухою парою - жарко, але добре. Ось сонячного удару застрахує панама, тінь і своєчасну втечу в прохолоду кондиціонованих приміщень (зазвичай з полудня і до п'ятої вечора).</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в серпні</h5>
                                    <p>Обжигающий пісок, сліпуче сонце і соковита зелень навколо - таким буде Серпневий Шарм-ель-Шейх. Середньоденна температура досягає позначки в + 43 ° C! У такі моменти дякуєш винахідника кондиціонерів! Погода в Шарм-ель-Шейху в серпні немов піч. Особливо з полудня і до вечора. Якщо чесно, наслідках і ночами. Після заходу градусник демонструє + 30 ° C. За рахунок сухості клімату, навіть таке пекло терпимо. Акваторія, нагріта до + 29 ° C, завжди допоможе охолонути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в вересні</h5>
                                    <p>Середньоденна температура знижується до + 38 ° C. Погода в Шарм-ель-Шейху в вересні набагато м'якше предидущемесячной. Нічна температура буде дорівнює середнім + 26 ° C. Тільки не потрібно чекати прохолоди в першій же декаді, вона буде скоріше схожа на серпневу ситуацію. Поспішати розлучатися з коштами від сонячних опіків і головних уборів Не варто. Акваторія анітрохи ні остигає, все той же + 29 ° C.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в жовтні</h5>
                                    <p>Погода в Шарм-ель-Шейху в жовтні знає відповідь. Пора в Єгипет! Доказів на користь цього напрямку маса. Море ще тепле, його температура дорівнює + 27 ° C. Турботливі службовці готелю навіть розчищають місцями захід у море від каменів! Залишається тільки насолоджуватися купання в солоній воді. Середньоденна температура досягає + 33 ° C. Вночі цифра змінюється на + 27 ° C. Таким чином, при світлі дня терпимо жарко, а після заходу сонця - саме те. А ще погода в жовтні в Шарм-ель-Шейху екскурсійно-адекватна. Взимку заважають вітру, влітку спека, а міжсезоння прекрасно підійде для знайомства з визначними пам'ятками.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в листопаді</h5>
                                    <p>Погода в Шарм-ель-Шейху в листопаді того підтвердження. Вдень температура тримається на середньому рівні в + 28 ° C. Ночами курорт остигає до + 19 ° C. замерзнути при такому розкладі складно, але можна. Все-таки пустеля колом, і тепла кофта повинна занять почесне місце в багажі (дуже стане в нагоді після заходу). Навіть море ще в тонусі, його тепло одно + 26 ° C, що цілком можна купатися. Погода в листопаді в Шарм-ель-Шейху буває і мокрою. Правда. Сумарна кількість осадом мізерно мало, а тому переживання в сторону.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в грудні</h5>
                                    <p>Погода в Шарм-ель-Шейху в грудні різниться як раз по районному фактора. Проблема в властивих Єгипту зимових вітрах. Старт місяці - це середньоденні + 24 ° C, в цей час і море прогріти до комфортних + 25 ° C, і ночами досить кофтинки тепліше, щоб не змерзнути. У той же час днем ​​- тепло: можна позасмагати в своє задоволення або відправитися на екскурсію. На комфорті більш пізнього перебування позначиться розташування готелю. Ідеалом стане будь-яка з бухт - захищений від вітру пляж - щастя зимових туристів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
           }
              }
           );
            /* Old Vic Sharm Resort 4 **/
            tourList.Add(
               new TourVM
              {
                  Id = 8,
                  Name = "Египт",
                  Start = new DateTime(2021, 7, 3, 14, 4, 5),
                  End = new DateTime(2021, 7, 10, 18, 5, 5),
                  DeparturePlace = "Київ",
                  ArivalFromPlace = "Шарм-Ель-Шейх",
                  FoodSupplyType = "все включено",
                  TravelerTypes = "1 дорослий",
                  PeopleCount = 1,
                  HotelStars = 5,
                  Costs = 11_645,
                  Carousel = new Carousel
                  {
                      ImgList = new List<CarouselImg>()
               {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/egypt/old-vic-sharm-resort-4/0.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/old-vic-sharm-resort-4/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/egypt/old-vic-sharm-resort-4/1.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/old-vic-sharm-resort-4/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/egypt/old-vic-sharm-resort-4/2.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/old-vic-sharm-resort-4/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/egypt/old-vic-sharm-resort-4/3.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/old-vic-sharm-resort-4/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/egypt/old-vic-sharm-resort-4/4.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/old-vic-sharm-resort-4/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/egypt/old-vic-sharm-resort-4/5.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/old-vic-sharm-resort-4/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/egypt/old-vic-sharm-resort-4/6.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/old-vic-sharm-resort-4/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 7,
                                Src ="/images/hotels/egypt/old-vic-sharm-resort-4/7.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/old-vic-sharm-resort-4/7.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 8,
                                Src ="/images/hotels/egypt/old-vic-sharm-resort-4/8.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/old-vic-sharm-resort-4/8.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 9,
                                Src ="/images/hotels/egypt/old-vic-sharm-resort-4/9.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/old-vic-sharm-resort-4/9.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                      },
                      ThumbList = new List<CarouselThumb>()
               {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/egypt/old-vic-sharm-resort-4/thumb/0.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/egypt/old-vic-sharm-resort-4/thumb/1.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/egypt/old-vic-sharm-resort-4/thumb/2.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/egypt/old-vic-sharm-resort-4/thumb/3.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/egypt/old-vic-sharm-resort-4/thumb/4.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/egypt/old-vic-sharm-resort-4/thumb/5.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/egypt/old-vic-sharm-resort-4/thumb/6.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 7,
                                Src= "/images/hotels/egypt/old-vic-sharm-resort-4/thumb/7.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 8,
                                Src= "/images/hotels/egypt/old-vic-sharm-resort-4/thumb/8.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                             new CarouselThumb
                            {
                                Id = 9,
                                Src= "/images/hotels/egypt/old-vic-sharm-resort-4/thumb/9.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                      }
                  },
                  Services = new List<TourService>
           {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія"
                        },
           },
                  InfoBlocks = new List<TourInfoBlock>
           {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <p>Готель пропонує своїм гостям просторі, комфортабельні номери, 2 ресторани, 3 бари, відкриті басейни для дорослих і дітей, безкоштовний Wi-Fi в громадських місцях готелю, а також харчування за концепцією 'Все включено'. До піщаного пляжу за кілька хвилин доставить готельний Шаттл.</p>
                                          <table class='table table-striped'>
                                            <tbody>
                                               <tr>
                                                <th scope = 'row'>Розташування</th>
                                                <td>Готель розташованій в 7 км від центру міста Наама Бей, в 2 км від вулиці Меркато, в 15 км від міжнародного аеропорту м Шарм-ель-Шейха. Загальна площа территории готелю - 12000 кв. м. Рік побудова готелю - 2017 р.</td>
                                                </tr>
                                              <tr>
                                                <th scope = 'row'>Розміщення</th>
                                                   <td>
                                                     <p>Готель складається з чотирьох 3-поверхових корпусів.</p>
                                                     <span>Всього 136 номерів.</span>
                                                     <span>До розміщення пропонуються:<span>
                                                  <ul>
                                                    <li><strong>Standard</strong> (54 кв. М, двоспальне або односпальні ліжка)</li>
                                                    <li><strong>Superior</strong> (65 кв. М, двоспальне і односпальне ліжка)</li>
                                                   </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>ванна кімната</li>
                                                    <li>фен</li>
                                                    <li>кондиціонер</li>
                                                    <li>ТВ</li>
                                                    <li>телефон</li>
                                                    <li>сейф</li>
                                                    <li>міні-бар (порожній)</li>
                                                    <li>набір для чаю і кави</li>
                                                    <li>тераса / балкон (10 номерів без балкона)</li>
                                                    <li>прибирання номера (щодня)</li>
                                                    <li>зміна постільної білизни (щодня)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Територія</th>
                                                <td>
                                                  <ul>
                                                    <li>Wi-Fi в громадських місцях готелю (лімітований - безкоштовно)</li>
                                                    <li>пральня (платно)</li>
                                                    <li>послуги доктора (платно)</li>
                                                    <li>парковка</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Опис All Inclusive</th>
                                                <td>
                                                  Готель пропонує харчування по системі<b> All Inclusive:</b>
                                                  <ul>
                                                    <li>сніданок (07: 00-10: 00, шведський стіл, головний ресторан)</li>
                                                    <li>обід (13: 00-15: 00, шведський стіл, головний ресторан)</li>
                                                    <li>вечеря (19: 00-21: 00, шведський стіл, головний ресторан)</li>
                                                    <li>закуски, кава, чай, випічка (в певні години)</li>
                                                    <li>місцеві алкогольні і безалкогольні напої</li>
                                                  </ul>
                                               <p><strong>За додаткову плату:</strong> імпортні напої, бутильовані напої.</p>
                                               </td>
                                              <tr>
                                                <th scope = 'row'>Ресторани і бари</th>
                                                <td>
                                                  <ul>
                                                    <li>головний ресторан (сніданок, обід, вечеря)</li>
                                                    <li>ресторан a la carte 'Amigoo' (італійська і середземноморська кухні)</li>
                                                    <li>лобі-бар (24 години)</li>
                                                    <li>бедуїнське кафе</li>
                                                    <li>спорт-бар</li>
                                                  </ul> 
                                               </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>•	Кредитні картки</th>
                                                <td>
                                                  <ul>
                                                    <li>Visa, MasterCard</li>
                                                  </ul> 
                                               </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    <p>Власний піщаний (Шарм-ель-Майя), в 2,8 км від готелю.</p>
                                    <p>немає коралів.</p>
                                    <p>Шаттл-бас до пляжу - безкоштовно.</p>
                                    <p><strong>Пляжний інвентар - безкоштовно.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/hotels/egypt/sharm-el/sharm-el-1.jpg' /></p>
                                      <p>Різноманітність видів морських мешканців і сотні коралових рифів Червоного моря роблять Шарм-ель-Шейх особливо привабливим для любителів дайвінгу та еко-туризму. Заснована на туризмі економіка цього міста, розташованого на Синайському півострові, за останні кілька десятиліть пережила значний підйом, що стало причиною виникнення першокласних курортів і розквіту нічного життя.</p>
                                      <p>Серце всього Шарм-ель-Шейха - це Наама-Бей найяскравіший район курорту. Наама-Бей славиться своєю відмінною інфраструктурою. Тут є прогулянкова набережна, казино, безліч ресторанів, барів і кафе, розважальні клуби, нічні дискотеки, екскурсійні бюро та безліч інших закладів.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <ul>
                                                <li>відкритий басейн (1000 кв. М)</li>
                                                <li>SPA-центр (платно)</li>
                                                <li>турецька лазня (платно)</li>
                                                <li>сауна (платно)</li>
                                                <li>масаж (платно)</li>
                                                <li>тренажерний зал</li>
                                                <li>більярд (платно)</li>
                                                <li>Пляжний волейбол</li>
                                                <li>водні види спорту на пляжі (платно)</li>
                                                <li>водні види спорту на пляжі (платно)</li>
                                                <li>дайвінг-центр (платно)</li>
                                               </ul>
                                             </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>дитячий відкритий басейн</li>
                                                <li>дитячий ігровий майданчик</li>
                                                <li>дитяча анімація</li>
                                                <li>дитячі стільці в ресторані</li>
                                                <li>дитяче ліжечко (безкоштовно; на вимогу)</li>
                                               </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в січні</h5>
                                    <p>Погода в січні в Шарм-ель-Шейху суха. Опади вірогідні, але якщо з неба і впадуть краплі, то цього ніхто не помітить. Якщо вдень стовпчик термометра дотягує до + 22 ° C, так само як і тіло акваторії; то після заходу ситуація змінюється. Термометр покаже тільки + 13 ° C. Погода в Шарм-ель-Шейху в січні не дасть розслабитися. Теплі речі Повинні занять почесне місце у валізі. Але нехтувати купальник не варто! У басейнах при готелях температура води незмінно річна. А в безвітряну погоду можна з комфортом поніжитися під сонцем біля моря. Головне пам'ятати, червоний прапор на пляжі - знак заборони на купання.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в лютому</h5>
                                    <p>Під кінець зимового періоду ситуація в Шарм-ель-Шейху мало відрізняється від попередньої їй. Море »подморожена». Його температура чи дотягує до двадцяти градусів за Цельсієм зі знаком плюс. Це погода в Шарм-ель-Шейху в лютому постаралася. Зате, якщо купання НЕ є Наріжним каменем подорожі, можна чудово провести час. В Єгипті чимало пам'ятки, яким НЕ насолодишся в високий сезон і під палючим сонцем. У світлий час доби погода в лютому в Шарм-ель-Шейху нагріє повітря до + 25 ° C в середньому. Після заходу стане в нагоді вітровка, за вікном буде всього + 17 ° C. Серед інших плюсів - відсутність дощів.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в березні</h5>
                                    <p>Поки що на березі комфортно тільки приймати сонячні ванни. Погода в Шрам-ель-Шейху в березні подбала лише про теплі навколо. У воді ж всього + 21 ° C! Зате на березі можна знемагати від спеки, температура повітря часом доходить до + 35 ° C. При таких успіхи, навіть море «відтане» на градус-другий. Середніми ж показниками прогріву повітря стануть + 24 ° C в світлий час доби і + 17 ° C після заходу сонця. Но погода в марте в Шарм-Эль-Шейхе достаточно динамична. И динамика эта положительна. То есть от декады к декаде будет жарче. При этом о дождях можно не беспокоиться, их вероятность сведена к минимуму. Но теплые вещи для вечерних прогулок и на случай сильного ветра (который непременно налетит) взять с собой рекомендуется.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в квітні</h5>
                                    <p>Погода в квітні в Шарм-ель-Шейху непередбачувана в вітро-плані. Так що, побоюватися варто «хамсин». Піщаний вихор налітає раптово, і також несподівано стихає. Теплі речі НЕ знадобляться вже і по ночах, прогретими до + 23 ° C в середньому. Зате довгий рукав або спеціальні засоби врятують від комарів, які можуть докучати відпочиваючим.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в травні</h5>
                                    <p>Погода в Шарм-ель-Шейху в травні Адекватне нікуди. Середньоденний тепло досягає + 34 ° C. З урахуванням кліматичної сухості, відчуття від такого режиму найприємніші. Головне не забувати користуватися кремом від сонця, промені його підступні. Ночами градусник термометра опускається до + 24 ° C. Заспокоюють вітру, а разом з ними і Акваторія, прогріта до + 26 ° C. Маленьким гостям курорту вже НЕ загрожують морські хвилювання. До речі, погода в травні в Шарм-ель-Шейху, кілька підступна. Мінусом штиль стануть комарі, варто подбати про захист.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в червні</h5>
                                    <p>Ось середніх + 37 ° C і до максимальних + 46 ° C - такий градусний розкид очікує біля берега Червоного моря. Погода в Шарм-ель-Шейху в червні все ще милосердна. Низький рівень вологості дозволяє дихати на повні груди, особливо після заходу сонця. Тоді градусник покаже всього + 26 ° C в середньому. А як нагрілося море! + 27 ° C - це коли в воді хочеться проводить годинник. І вся ця сіненебая безхмарність укупі з сухою, але все-таки спекою, може навіть набриднути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в липні</h5>
                                    <p>Погода в Шарм-ель-Шейху в червні дружить з цифрами за сорок. Добре, що в нічні години стовпчик термометра опускається до позначки в + 27 ° C в середньому. Але денні + 40 ° C і більше нікого тут НЕ дивуватися в цей час. Навіщо ж їхати в таке пекло, будучи в равом розумі? Погода в липні в Шарм-ель-Шейху знайшла відповідь. Низька вологість перетворює курорт в подобу сауни з сухою парою - жарко, але добре. Ось сонячного удару застрахує панама, тінь і своєчасну втечу в прохолоду кондиціонованих приміщень (зазвичай з полудня і до п'ятої вечора).</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в серпні</h5>
                                    <p>Обжигающий пісок, сліпуче сонце і соковита зелень навколо - таким буде Серпневий Шарм-ель-Шейх. Середньоденна температура досягає позначки в + 43 ° C! У такі моменти дякуєш винахідника кондиціонерів! Погода в Шарм-ель-Шейху в серпні немов піч. Особливо з полудня і до вечора. Якщо чесно, наслідках і ночами. Після заходу градусник демонструє + 30 ° C. За рахунок сухості клімату, навіть таке пекло терпимо. Акваторія, нагріта до + 29 ° C, завжди допоможе охолонути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в вересні</h5>
                                    <p>Середньоденна температура знижується до + 38 ° C. Погода в Шарм-ель-Шейху в вересні набагато м'якше предидущемесячной. Нічна температура буде дорівнює середнім + 26 ° C. Тільки не потрібно чекати прохолоди в першій же декаді, вона буде скоріше схожа на серпневу ситуацію. Поспішати розлучатися з коштами від сонячних опіків і головних уборів Не варто. Акваторія анітрохи ні остигає, все той же + 29 ° C.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в жовтні</h5>
                                    <p>Погода в Шарм-ель-Шейху в жовтні знає відповідь. Пора в Єгипет! Доказів на користь цього напрямку маса. Море ще тепле, його температура дорівнює + 27 ° C. Турботливі службовці готелю навіть розчищають місцями захід у море від каменів! Залишається тільки насолоджуватися купання в солоній воді. Середньоденна температура досягає + 33 ° C. Вночі цифра змінюється на + 27 ° C. Таким чином, при світлі дня терпимо жарко, а після заходу сонця - саме те. А ще погода в жовтні в Шарм-ель-Шейху екскурсійно-адекватна. Взимку заважають вітру, влітку спека, а міжсезоння прекрасно підійде для знайомства з визначними пам'ятками.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в листопаді</h5>
                                    <p>Погода в Шарм-ель-Шейху в листопаді того підтвердження. Вдень температура тримається на середньому рівні в + 28 ° C. Ночами курорт остигає до + 19 ° C. замерзнути при такому розкладі складно, але можна. Все-таки пустеля колом, і тепла кофта повинна занять почесне місце в багажі (дуже стане в нагоді після заходу). Навіть море ще в тонусі, його тепло одно + 26 ° C, що цілком можна купатися. Погода в листопаді в Шарм-ель-Шейху буває і мокрою. Правда. Сумарна кількість осадом мізерно мало, а тому переживання в сторону.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в грудні</h5>
                                    <p>Погода в Шарм-ель-Шейху в грудні різниться як раз по районному фактора. Проблема в властивих Єгипту зимових вітрах. Старт місяці - це середньоденні + 24 ° C, в цей час і море прогріти до комфортних + 25 ° C, і ночами досить кофтинки тепліше, щоб не змерзнути. У той же час днем ​​- тепло: можна позасмагати в своє задоволення або відправитися на екскурсію. На комфорті більш пізнього перебування позначиться розташування готелю. Ідеалом стане будь-яка з бухт - захищений від вітру пляж - щастя зимових туристів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
                  }
              }
           );
            /*amwaj-oyoun-resort-casino-5*/
            tourList.Add(
               new TourVM
             {
                 Id = 9,
                 Name = "Египт",
                 Start = new DateTime(2021, 7, 3, 14, 4, 5),
                 End = new DateTime(2021, 7, 10, 18, 5, 5),
                 DeparturePlace = "Київ",
                 ArivalFromPlace = "Шарм-Ель-Шейх",
                 FoodSupplyType = "все включено",
                 TravelerTypes = "1 дорослий",
                 PeopleCount = 1,
                 HotelStars = 5,
                 Costs = 11_645,
                 Carousel = new Carousel
                 {
                     ImgList = new List<CarouselImg>()
              {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/egypt/amwaj-oyoun-resort-casino-5/0.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/egypt/amwaj-oyoun-resort-casino-5/1.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/egypt/amwaj-oyoun-resort-casino-5/2.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/egypt/amwaj-oyoun-resort-casino-5/3.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/egypt/amwaj-oyoun-resort-casino-5/4.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/egypt/amwaj-oyoun-resort-casino-5/5.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/egypt/amwaj-oyoun-resort-casino-5/6.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 7,
                                Src ="/images/hotels/egypt/amwaj-oyoun-resort-casino-5/7.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/7.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 8,
                                Src ="/images/hotels/egypt/amwaj-oyoun-resort-casino-5/8.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/8.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 9,
                                Src ="/images/hotels/egypt/amwaj-oyoun-resort-casino-5/9.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/9.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 10,
                                Src ="/images/hotels/egypt/amwaj-oyoun-resort-casino-5/10.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/10.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },

                     },
                     ThumbList = new List<CarouselThumb>()
              {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/0.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/1.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/2.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/3.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/4.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/5.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/6.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 7,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/7.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 8,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/8.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                             new CarouselThumb
                            {
                                Id = 9,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/9.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                               new CarouselThumb
                            {
                                Id = 10,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/10.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                     }
                 },
                 Services = new List<TourService>
          {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія"
                        },
          },
                 InfoBlocks = new List<TourInfoBlock>
          {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <p>П'ятизірковий готель розташований у відокремленому місці на розкішному піщаному пляжі, протяжністю 650 м на березі Червоного моря в затоці Набк.</p>
                                          <table class='table table-striped'>
                                            <tbody>
                                               <tr>
                                                <th scope = 'row'>Розташування</th>
                                                <td>Готель розташований в затоці Набк, в крокової доступності від декількох великих торгових центрів, нічних клубів, ресторанів і кафе, в 9 км від аеропорту, в 20 км від центру Наама Бей і в 26 км від старого міста.</td>
                                                </tr>
                                              <tr>
                                                <th scope = 'row'>Розміщення</th>
                                                   <td>
                                                   <span>До розміщення пропонуються:<span>
                                                  <ul>
                                                    <li><strong>274 Superior Room</strong> (32 кв. М, номери знаходяться в основній будівлі, однокімнатні з балконом / терасою, вид на сад / на басейн / на море)</li>
                                                    <li><strong>18 Family Room</strong> (48 кв. М, номери знаходяться в основній будівлі, з балконом / терасою, вид на сад / на басейн)</li>
                                                    <li><strong>12 Executive Suite</strong> (54 кв.м, номери знаходяться в основній будівлі, з балконом / терасою, вид на сад / на басейн / на море)</li>
                                                    <li><strong>161 Standard Room</strong> (32 кв. М, номери знаходяться в Relax Building, вид на внутреннуюю територію, на басейн)</li>
                                                   </ul>
                                                    <p>Більшість номерів мають суміжні двері.</p>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>ванна кімната з ванною / душем</li>
                                                    <li>фен</li>
                                                    <li>кондиціонер</li>
                                                    <li>ТВ</li>
                                                    <li>телефон</li>
                                                    <li>сейф</li>
                                                    <li>Wi-Fi (платно)</li>
                                                    <li>набір для чаю і кави</li>
                                                    <li>міні-бар</li>
                                                    <li>балкон / тераса</li>
                                                   </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Територія</th>
                                                <td>
                                                  <ul>
                                                    <li>Wi-Fi в лобі (безкоштовно)</li>
                                                    <li>парковка (безкоштовно)</li>
                                                    <li>пральня (платно)</li>
                                                    <li>камера схову багажу</li>
                                                    <li>банкомат</li>
                                                    <li>магазини (платно)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Опис All Inclusive</th>
                                                <td>
                                                  Готель пропонує харчування по системі<b> All Inclusive:</b>
                                                  <ul>
                                                    <li>сніданок (7:30 - 10:00)</li>
                                                    <li>обід (12:30 - 13:30; 14:00 - 15:00)</li>
                                                    <li>вечеря (19:00 - 20:00; 20:30 - 21:30)</li>
                                                    <li>закуски в барі біля басейну (15: 30-17: 00)</li>
                                                    <li>місцеві алкогольні і безалкогольні напої (10: 00-00: 00)</li>
                                                    <li>після 00:00 до 10:00 діє спеціальна пропозиція на алкогольні і безалкогольні напої</li>
                                                  </ul>
                                               <p><strong>За додаткову плату:</strong> імпортні напої, бутильовані напої.</p>
                                               </td>
                                              <tr>
                                                <th scope = 'row'>Ресторани і бари</th>
                                                <td>
                                                  <ul>
                                                    <li>ресторан 'Oyoun' (сніданок, обід, вечеря)</li>
                                                    <li>італійський ресторан a la carte 'Primi Piatti'</li>
                                                    <li>бар і ресторан біля басейну</li>
                                                    <li>бар-ресторан на пляжі 'Blue line'</li>
                                                    <li>африканський бар 'Soweto' (24 години, включаючи пізні закуски)</li>
                                                    <li>бар 'Atrium'</li>
                                                    <li>бар 'Terrace'</li>
                                                    <li>бар 'Relax'</li>
                                                  </ul> 
                                               </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>•	Кредитні картки</th>
                                                <td>
                                                  <ul>
                                                    <li>Visa, MasterCard</li>
                                                  </ul> 
                                               </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    <p>Власний пляж, протяжність - 650 м, вхід в море по понтону (320 м).</p>
                                    <p>Пляжні рушники, парасольки і шезлонги - безкоштовно.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/hotels/egypt/sharm-el/sharm-el-1.jpg' /></p>
                                      <p>П'ятизірковий готель розташований у відокремленому місці на розкішному піщаному пляжі, протяжністю 650 м на березі Червоного моря в затоці Набк.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <ul>
                                                <li>3 головних басейну</li>
                                                <li>1 басейн з підігрівом</li>
                                                <li>Relax басейн</li>
                                                <li>1 басейн з водними гірками</li>
                                                <li>тренажерний зал і студія аеробіки</li>
                                                <li>освітлюваний тенісний корт (після заходу платно)</li>
                                                <li>пляжний волейбол</li>
                                                <li>майданчик для міні футболу на пляжі</li>
                                                <li>настільний теніс</li>
                                                <li>водне поло</li>
                                                <li>SPA-центр (платно)</li>
                                                <li>сауна (платно)</li>
                                                <li>парна (платно)</li>
                                                <li>джакузі (платно)</li>
                                                <li>массаж (платно)</li>
                                                <li>казино «ВЕГАС» (рядом с главным входом в отель)</li>
                                               </ul>
                                             </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>2 дитячих басейну</li>
                                                <li>1 велика водна гірка для дітей</li>
                                                <li>дитячий ігровий майданчик</li>
                                                <li>дитячий міні-клуб (4-12 років)</li>
                                                <li>дитяча анімація</li>
                                                <li>дитяче ліжечко (за запитом)</li>
                                                <li>дитячі стільці в ресторані</li>
                                               </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в січні</h5>
                                    <p>Погода в січні в Шарм-ель-Шейху суха. Опади вірогідні, але якщо з неба і впадуть краплі, то цього ніхто не помітить. Якщо вдень стовпчик термометра дотягує до + 22 ° C, так само як і тіло акваторії; то після заходу ситуація змінюється. Термометр покаже тільки + 13 ° C. Погода в Шарм-ель-Шейху в січні не дасть розслабитися. Теплі речі Повинні занять почесне місце у валізі. Але нехтувати купальник не варто! У басейнах при готелях температура води незмінно річна. А в безвітряну погоду можна з комфортом поніжитися під сонцем біля моря. Головне пам'ятати, червоний прапор на пляжі - знак заборони на купання.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в лютому</h5>
                                    <p>Під кінець зимового періоду ситуація в Шарм-ель-Шейху мало відрізняється від попередньої їй. Море »подморожена». Його температура чи дотягує до двадцяти градусів за Цельсієм зі знаком плюс. Це погода в Шарм-ель-Шейху в лютому постаралася. Зате, якщо купання НЕ є Наріжним каменем подорожі, можна чудово провести час. В Єгипті чимало пам'ятки, яким НЕ насолодишся в високий сезон і під палючим сонцем. У світлий час доби погода в лютому в Шарм-ель-Шейху нагріє повітря до + 25 ° C в середньому. Після заходу стане в нагоді вітровка, за вікном буде всього + 17 ° C. Серед інших плюсів - відсутність дощів.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в березні</h5>
                                    <p>Поки що на березі комфортно тільки приймати сонячні ванни. Погода в Шрам-ель-Шейху в березні подбала лише про теплі навколо. У воді ж всього + 21 ° C! Зате на березі можна знемагати від спеки, температура повітря часом доходить до + 35 ° C. При таких успіхи, навіть море «відтане» на градус-другий. Середніми ж показниками прогріву повітря стануть + 24 ° C в світлий час доби і + 17 ° C після заходу сонця. Но погода в марте в Шарм-Эль-Шейхе достаточно динамична. И динамика эта положительна. То есть от декады к декаде будет жарче. При этом о дождях можно не беспокоиться, их вероятность сведена к минимуму. Но теплые вещи для вечерних прогулок и на случай сильного ветра (который непременно налетит) взять с собой рекомендуется.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в квітні</h5>
                                    <p>Погода в квітні в Шарм-ель-Шейху непередбачувана в вітро-плані. Так що, побоюватися варто «хамсин». Піщаний вихор налітає раптово, і також несподівано стихає. Теплі речі НЕ знадобляться вже і по ночах, прогретими до + 23 ° C в середньому. Зате довгий рукав або спеціальні засоби врятують від комарів, які можуть докучати відпочиваючим.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в травні</h5>
                                    <p>Погода в Шарм-ель-Шейху в травні Адекватне нікуди. Середньоденний тепло досягає + 34 ° C. З урахуванням кліматичної сухості, відчуття від такого режиму найприємніші. Головне не забувати користуватися кремом від сонця, промені його підступні. Ночами градусник термометра опускається до + 24 ° C. Заспокоюють вітру, а разом з ними і Акваторія, прогріта до + 26 ° C. Маленьким гостям курорту вже НЕ загрожують морські хвилювання. До речі, погода в травні в Шарм-ель-Шейху, кілька підступна. Мінусом штиль стануть комарі, варто подбати про захист.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в червні</h5>
                                    <p>Ось середніх + 37 ° C і до максимальних + 46 ° C - такий градусний розкид очікує біля берега Червоного моря. Погода в Шарм-ель-Шейху в червні все ще милосердна. Низький рівень вологості дозволяє дихати на повні груди, особливо після заходу сонця. Тоді градусник покаже всього + 26 ° C в середньому. А як нагрілося море! + 27 ° C - це коли в воді хочеться проводить годинник. І вся ця сіненебая безхмарність укупі з сухою, але все-таки спекою, може навіть набриднути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в липні</h5>
                                    <p>Погода в Шарм-ель-Шейху в червні дружить з цифрами за сорок. Добре, що в нічні години стовпчик термометра опускається до позначки в + 27 ° C в середньому. Але денні + 40 ° C і більше нікого тут НЕ дивуватися в цей час. Навіщо ж їхати в таке пекло, будучи в равом розумі? Погода в липні в Шарм-ель-Шейху знайшла відповідь. Низька вологість перетворює курорт в подобу сауни з сухою парою - жарко, але добре. Ось сонячного удару застрахує панама, тінь і своєчасну втечу в прохолоду кондиціонованих приміщень (зазвичай з полудня і до п'ятої вечора).</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в серпні</h5>
                                    <p>Обжигающий пісок, сліпуче сонце і соковита зелень навколо - таким буде Серпневий Шарм-ель-Шейх. Середньоденна температура досягає позначки в + 43 ° C! У такі моменти дякуєш винахідника кондиціонерів! Погода в Шарм-ель-Шейху в серпні немов піч. Особливо з полудня і до вечора. Якщо чесно, наслідках і ночами. Після заходу градусник демонструє + 30 ° C. За рахунок сухості клімату, навіть таке пекло терпимо. Акваторія, нагріта до + 29 ° C, завжди допоможе охолонути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в вересні</h5>
                                    <p>Середньоденна температура знижується до + 38 ° C. Погода в Шарм-ель-Шейху в вересні набагато м'якше предидущемесячной. Нічна температура буде дорівнює середнім + 26 ° C. Тільки не потрібно чекати прохолоди в першій же декаді, вона буде скоріше схожа на серпневу ситуацію. Поспішати розлучатися з коштами від сонячних опіків і головних уборів Не варто. Акваторія анітрохи ні остигає, все той же + 29 ° C.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в жовтні</h5>
                                    <p>Погода в Шарм-ель-Шейху в жовтні знає відповідь. Пора в Єгипет! Доказів на користь цього напрямку маса. Море ще тепле, його температура дорівнює + 27 ° C. Турботливі службовці готелю навіть розчищають місцями захід у море від каменів! Залишається тільки насолоджуватися купання в солоній воді. Середньоденна температура досягає + 33 ° C. Вночі цифра змінюється на + 27 ° C. Таким чином, при світлі дня терпимо жарко, а після заходу сонця - саме те. А ще погода в жовтні в Шарм-ель-Шейху екскурсійно-адекватна. Взимку заважають вітру, влітку спека, а міжсезоння прекрасно підійде для знайомства з визначними пам'ятками.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в листопаді</h5>
                                    <p>Погода в Шарм-ель-Шейху в листопаді того підтвердження. Вдень температура тримається на середньому рівні в + 28 ° C. Ночами курорт остигає до + 19 ° C. замерзнути при такому розкладі складно, але можна. Все-таки пустеля колом, і тепла кофта повинна занять почесне місце в багажі (дуже стане в нагоді після заходу). Навіть море ще в тонусі, його тепло одно + 26 ° C, що цілком можна купатися. Погода в листопаді в Шарм-ель-Шейху буває і мокрою. Правда. Сумарна кількість осадом мізерно мало, а тому переживання в сторону.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в грудні</h5>
                                    <p>Погода в Шарм-ель-Шейху в грудні різниться як раз по районному фактора. Проблема в властивих Єгипту зимових вітрах. Старт місяці - це середньоденні + 24 ° C, в цей час і море прогріти до комфортних + 25 ° C, і ночами досить кофтинки тепліше, щоб не змерзнути. У той же час днем ​​- тепло: можна позасмагати в своє задоволення або відправитися на екскурсію. На комфорті більш пізнього перебування позначиться розташування готелю. Ідеалом стане будь-яка з бухт - захищений від вітру пляж - щастя зимових туристів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
                 }
             }
           );
            /* Turquoise Beach Hotel 4*/
            tourList.Add(
               new TourVM
             {
                 Id = 10,
                 Name = "Египт",
                 Start = new DateTime(2021, 7, 3, 14, 4, 5),
                 End = new DateTime(2021, 7, 10, 18, 5, 5),
                 DeparturePlace = "Київ",
                 ArivalFromPlace = "Шарм-Ель-Шейх",
                 FoodSupplyType = "все включено",
                 TravelerTypes = "1 дорослий",
                 PeopleCount = 1,
                 HotelStars = 4,
                 Costs = 11_645,
                 Carousel = new Carousel
                 {
                     ImgList = new List<CarouselImg>()
            {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/egypt/turquoise-beach-hotel-4/0.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/turquoise-beach-hotel-4/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/egypt/turquoise-beach-hotel-4/1.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/turquoise-beach-hotel-4/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/egypt/turquoise-beach-hotel-4/2.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/turquoise-beach-hotel-4/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/egypt/turquoise-beach-hotel-4/3.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/turquoise-beach-hotel-4/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/egypt/turquoise-beach-hotel-4/4.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/turquoise-beach-hotel-4/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/egypt/turquoise-beach-hotel-4/5.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/turquoise-beach-hotel-4/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/egypt/turquoise-beach-hotel-4/6.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/turquoise-beach-hotel-4/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 7,
                                Src ="/images/hotels/egypt/turquoise-beach-hotel-4/7.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/turquoise-beach-hotel-4/7.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 8,
                                Src ="/images/hotels/egypt/turquoise-beach-hotel-4/8.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/turquoise-beach-hotel-4/8.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                     },
                     ThumbList = new List<CarouselThumb>()
            {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/egypt/turquoise-beach-hotel-4/thumb/0.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/egypt/turquoise-beach-hotel-4/thumb/1.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/egypt/turquoise-beach-hotel-4/thumb/2.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/egypt/turquoise-beach-hotel-4/thumb/3.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/egypt/turquoise-beach-hotel-4/thumb/4.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/egypt/turquoise-beach-hotel-4/thumb/5.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/egypt/turquoise-beach-hotel-4/thumb/6.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 7,
                                Src= "/images/hotels/egypt/turquoise-beach-hotel-4/thumb/7.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 8,
                                Src= "/images/hotels/egypt/turquoise-beach-hotel-4/thumb/8.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                      }
                 },
                 Services = new List<TourService>
        {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія"
                        },
        },
                 InfoBlocks = new List<TourInfoBlock>
        {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <p>Готель, розташовані на другий берегової лінії, пропонує гостям просторі номери, серед яких є номери з видом на море, відкритий басейн для дорослих і дітей, харчування по концепціям 'Напівпансіон' і 'Все включено'.</p>
                                          <table class='table table-striped'>
                                            <tbody>
                                               <tr>
                                                <th scope = 'row'>Розташування</th>
                                                <td>Готель знаходиться на другій берегової лінії від бухти Шарм-Ель-Майя, в 500 м від Старого міста і ринку, в 25 км від аеропорту і 8 км від центру м Шарм-Ель-Шейх. Рік відкриття готелю - 2000 Остання реновація - 2015 р.</td>
                                               </tr>
                                              <tr>
                                                <th scope = 'row'>Розміщення</th>
                                                   <td>
                                                   <span>До розміщення пропонуються:<span>
                                                   <p>Готельний комплекс складає головної будівлі та комплексу 2-поверхових корпусів.</p>
                                                  <ul>
                                                    <li><strong>Standard</strong> (30 кв. М, двоспальне або 2 односпальні ліжка)</li>
                                                    <li><strong>Sea View</strong> (30 кв. М, двоспальне або 2 односпальні ліжка, вид на море)</li>
                                                  </ul>
                                                 </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>душ</li>
                                                    <li>фен</li>
                                                    <li>кондиціонер</li>
                                                    <li>ТВ</li>
                                                    <li>кондиціонер</li>
                                                    <li>телефон</li>
                                                    <li>міні-бар *</li>
                                                    <li>тераса / балкон (не у всіх номерах)</li>
                                                    <li>прибирання номера (щодня)</li>
                                                    <li>зміна постільної білизни та рушників (на вимогу)</li>
                                                    <li>сервіс в номер (24 години, платно)</li>
                                                    <li>сейф *</li>
                                                    <li>зміна постільної білизни та рушників (на вимогу)</li>
                                                   </ul>
                                                   <p>* Послуга може бути платною</p>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Територія</th>
                                                <td>
                                                  <ul>
                                                    <li>Wi-Fi в лобі (платно)</li>
                                                    <li>пральня (платно)</li>
                                                    <li>послуги доктора (за запитом; платно)</li>
                                                    <li>перукарня (платно)</li>
                                                    <li>прокат автомобіля (платно)</li>
                                                    <li>парковка (безкоштовно)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Опис All Inclusive</th>
                                                <td>
                                                    <ul>
                                                    <liсніданок (07: 00-10: 00)</li>
                                                    <li>обід (13: 00-15: 00)</li>
                                                    <li>вечеря (19: 00-21: 30)</li>
                                                    <li>напої місцевого виробництва</li>
                                                 </ul> 
                                                <p><b>За додаткову плату:</b></p>
                                                <p>свіжовичавлені соки, капучино, турецьку каву і еспресо, морозиво.</p>
                                               </td>
                                              <tr>
                                                <th scope = 'row'>Ресторани і бари</th>
                                                <td>
                                                  <ul>
                                                    <li>головний ресторан Paradise (міжнародна кухня; сніданок, обід, вечеря)</li>
                                                    <li>бар на пляжі</li>
                                                    <li>бар біля басейну</li>
                                                    <li>диско-бар (платно)</li>
                                                 </ul> 
                                               </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>•	Кредитні картки</th>
                                                <td>
                                                  <ul>
                                                    <li>Visa, MasterCard</li>
                                                  </ul> 
                                               </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    <p>Власний піщаний, в 500 м через дорогу від готелю.</p>
                                    <p>Пляжний інвентар - безкоштовно.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/hotels/egypt/sharm-el/sharm-el-1.jpg' /></p>
                                      <p>Різноманітність видів морських мешканців і сотні коралових рифів Червоного моря роблять Шарм-ель-Шейх особливо привабливим для любителів дайвінгу та еко-туризму. Заснована на туризмі економіка цього міста, розташованого на Синайському півострові, за останні кілька десятиліть пережила значний підйом, що стало причиною виникнення першокласних курортів і розквіту нічного життя.</p>
                                      <p>Серце всього Шарм-ель-Шейха - це Наама-Бей найяскравіший район курорту. Наама-Бей славиться своєю відмінною інфраструктурою. Тут є прогулянкова набережна, казино, безліч ресторанів, барів і кафе, розважальні клуби, нічні дискотеки, екскурсійні бюро та безліч інших закладів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <ul>
                                                <li>відкритий басейн (600 кв. м)</li>
                                                <li>настільний теніс/li>
                                                <li>дартс</li>
                                                <li>бочче</li>
                                                <li>більярд (платно)</li>
                                                <li>анімація (легка)/li>
                                                <li>пляжний волейбол</li>
                                                <li>водні види спорту на пляжі (платно)</li>
                                               </ul>
                                             </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>дитячий відкритий басейн (секція в дорослому)</li>
                                                <li>дитяче ліжечко (за запитом)</li>
                                                <li>дитячі стільці в ресторані</li>
                                              </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в січні</h5>
                                    <p>Погода в січні в Шарм-ель-Шейху суха. Опади вірогідні, але якщо з неба і впадуть краплі, то цього ніхто не помітить. Якщо вдень стовпчик термометра дотягує до + 22 ° C, так само як і тіло акваторії; то після заходу ситуація змінюється. Термометр покаже тільки + 13 ° C. Погода в Шарм-ель-Шейху в січні не дасть розслабитися. Теплі речі Повинні занять почесне місце у валізі. Але нехтувати купальник не варто! У басейнах при готелях температура води незмінно річна. А в безвітряну погоду можна з комфортом поніжитися під сонцем біля моря. Головне пам'ятати, червоний прапор на пляжі - знак заборони на купання.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в лютому</h5>
                                    <p>Під кінець зимового періоду ситуація в Шарм-ель-Шейху мало відрізняється від попередньої їй. Море »подморожена». Його температура чи дотягує до двадцяти градусів за Цельсієм зі знаком плюс. Це погода в Шарм-ель-Шейху в лютому постаралася. Зате, якщо купання НЕ є Наріжним каменем подорожі, можна чудово провести час. В Єгипті чимало пам'ятки, яким НЕ насолодишся в високий сезон і під палючим сонцем. У світлий час доби погода в лютому в Шарм-ель-Шейху нагріє повітря до + 25 ° C в середньому. Після заходу стане в нагоді вітровка, за вікном буде всього + 17 ° C. Серед інших плюсів - відсутність дощів.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в березні</h5>
                                    <p>Поки що на березі комфортно тільки приймати сонячні ванни. Погода в Шрам-ель-Шейху в березні подбала лише про теплі навколо. У воді ж всього + 21 ° C! Зате на березі можна знемагати від спеки, температура повітря часом доходить до + 35 ° C. При таких успіхи, навіть море «відтане» на градус-другий. Середніми ж показниками прогріву повітря стануть + 24 ° C в світлий час доби і + 17 ° C після заходу сонця. Но погода в марте в Шарм-Эль-Шейхе достаточно динамична. И динамика эта положительна. То есть от декады к декаде будет жарче. При этом о дождях можно не беспокоиться, их вероятность сведена к минимуму. Но теплые вещи для вечерних прогулок и на случай сильного ветра (который непременно налетит) взять с собой рекомендуется.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в квітні</h5>
                                    <p>Погода в квітні в Шарм-ель-Шейху непередбачувана в вітро-плані. Так що, побоюватися варто «хамсин». Піщаний вихор налітає раптово, і також несподівано стихає. Теплі речі НЕ знадобляться вже і по ночах, прогретими до + 23 ° C в середньому. Зате довгий рукав або спеціальні засоби врятують від комарів, які можуть докучати відпочиваючим.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в травні</h5>
                                    <p>Погода в Шарм-ель-Шейху в травні Адекватне нікуди. Середньоденний тепло досягає + 34 ° C. З урахуванням кліматичної сухості, відчуття від такого режиму найприємніші. Головне не забувати користуватися кремом від сонця, промені його підступні. Ночами градусник термометра опускається до + 24 ° C. Заспокоюють вітру, а разом з ними і Акваторія, прогріта до + 26 ° C. Маленьким гостям курорту вже НЕ загрожують морські хвилювання. До речі, погода в травні в Шарм-ель-Шейху, кілька підступна. Мінусом штиль стануть комарі, варто подбати про захист.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в червні</h5>
                                    <p>Ось середніх + 37 ° C і до максимальних + 46 ° C - такий градусний розкид очікує біля берега Червоного моря. Погода в Шарм-ель-Шейху в червні все ще милосердна. Низький рівень вологості дозволяє дихати на повні груди, особливо після заходу сонця. Тоді градусник покаже всього + 26 ° C в середньому. А як нагрілося море! + 27 ° C - це коли в воді хочеться проводить годинник. І вся ця сіненебая безхмарність укупі з сухою, але все-таки спекою, може навіть набриднути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в липні</h5>
                                    <p>Погода в Шарм-ель-Шейху в червні дружить з цифрами за сорок. Добре, що в нічні години стовпчик термометра опускається до позначки в + 27 ° C в середньому. Але денні + 40 ° C і більше нікого тут НЕ дивуватися в цей час. Навіщо ж їхати в таке пекло, будучи в равом розумі? Погода в липні в Шарм-ель-Шейху знайшла відповідь. Низька вологість перетворює курорт в подобу сауни з сухою парою - жарко, але добре. Ось сонячного удару застрахує панама, тінь і своєчасну втечу в прохолоду кондиціонованих приміщень (зазвичай з полудня і до п'ятої вечора).</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в серпні</h5>
                                    <p>Обжигающий пісок, сліпуче сонце і соковита зелень навколо - таким буде Серпневий Шарм-ель-Шейх. Середньоденна температура досягає позначки в + 43 ° C! У такі моменти дякуєш винахідника кондиціонерів! Погода в Шарм-ель-Шейху в серпні немов піч. Особливо з полудня і до вечора. Якщо чесно, наслідках і ночами. Після заходу градусник демонструє + 30 ° C. За рахунок сухості клімату, навіть таке пекло терпимо. Акваторія, нагріта до + 29 ° C, завжди допоможе охолонути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в вересні</h5>
                                    <p>Середньоденна температура знижується до + 38 ° C. Погода в Шарм-ель-Шейху в вересні набагато м'якше предидущемесячной. Нічна температура буде дорівнює середнім + 26 ° C. Тільки не потрібно чекати прохолоди в першій же декаді, вона буде скоріше схожа на серпневу ситуацію. Поспішати розлучатися з коштами від сонячних опіків і головних уборів Не варто. Акваторія анітрохи ні остигає, все той же + 29 ° C.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в жовтні</h5>
                                    <p>Погода в Шарм-ель-Шейху в жовтні знає відповідь. Пора в Єгипет! Доказів на користь цього напрямку маса. Море ще тепле, його температура дорівнює + 27 ° C. Турботливі службовці готелю навіть розчищають місцями захід у море від каменів! Залишається тільки насолоджуватися купання в солоній воді. Середньоденна температура досягає + 33 ° C. Вночі цифра змінюється на + 27 ° C. Таким чином, при світлі дня терпимо жарко, а після заходу сонця - саме те. А ще погода в жовтні в Шарм-ель-Шейху екскурсійно-адекватна. Взимку заважають вітру, влітку спека, а міжсезоння прекрасно підійде для знайомства з визначними пам'ятками.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в листопаді</h5>
                                    <p>Погода в Шарм-ель-Шейху в листопаді того підтвердження. Вдень температура тримається на середньому рівні в + 28 ° C. Ночами курорт остигає до + 19 ° C. замерзнути при такому розкладі складно, але можна. Все-таки пустеля колом, і тепла кофта повинна занять почесне місце в багажі (дуже стане в нагоді після заходу). Навіть море ще в тонусі, його тепло одно + 26 ° C, що цілком можна купатися. Погода в листопаді в Шарм-ель-Шейху буває і мокрою. Правда. Сумарна кількість осадом мізерно мало, а тому переживання в сторону.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в грудні</h5>
                                    <p>Погода в Шарм-ель-Шейху в грудні різниться як раз по районному фактора. Проблема в властивих Єгипту зимових вітрах. Старт місяці - це середньоденні + 24 ° C, в цей час і море прогріти до комфортних + 25 ° C, і ночами досить кофтинки тепліше, щоб не змерзнути. У той же час днем ​​- тепло: можна позасмагати в своє задоволення або відправитися на екскурсію. На комфорті більш пізнього перебування позначиться розташування готелю. Ідеалом стане будь-яка з бухт - захищений від вітру пляж - щастя зимових туристів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
               }
             }
           );
            /*Sharm Bride Aqua Hotel &Spa 4*/
            tourList.Add(
            new TourVM
            {
                Id = 11,
                Name = "Египт",
                Start = new DateTime(2021, 7, 3, 14, 4, 5),
                End = new DateTime(2021, 7, 10, 18, 5, 5),
                DeparturePlace = "Київ",
                ArivalFromPlace = "Шарм-эль-Шейх",
                FoodSupplyType = "все включено",
                TravelerTypes = "1 дорослий",
                PeopleCount = 1,
                HotelStars = 4,
                Costs = 11_645,
                Carousel = new Carousel
                {
                    ImgList = new List<CarouselImg>()
                {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/0.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/1.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/2.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/3.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/sharm-bride-aqua-hotel-spa-4/4.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/sharm-bride-aqua-hotel-spa-4/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/5.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/6.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 7,
                                Src ="/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/7.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/7.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 8,
                                Src ="/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/8.jpg",
                                Alt = "Sharm el Sheikh",
                                DataRemote= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/8.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                },
                    ThumbList = new List<CarouselThumb>()
                {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/thumb/0.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/thumb/1.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/thumb/2.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/thumb/3.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/thumb/4.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/thumb/5.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/thumb/6.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 7,
                                Src= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/thumb/7.jpg",
                                Alt = "Sharm el Sheikh",
                            },
                            new CarouselThumb
                            {
                                Id = 8,
                                Src= "/images/hotels/egypt/sharm-bride-aqua-hotel-spa-4/thumb/8.jpg",
                                Alt = "Sharm el Sheikh",
                            }
                }
                },
                Services = new List<TourService>
            {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія"
                        },
            },
                InfoBlocks = new List<TourInfoBlock>
            {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <p>Готель розташований в районі затоки Набк, в 16 км від Наама Бей і в 8 км від міжнародного аеропорту м Шарм-ель-Шейх. Загальна площа території готелю - 14000 кв. м. Рік побудови готелю - 2008 Остання реновація - 2019 р.</p>
                                          <table class='table table-striped'>
                                            <tbody>
                                               <tr>
                                                <th scope = 'row'>Розташування</th>
                                                <td> Готель знаходиться в 2 км від моря, в районі Хадаба, в 2 км від центру міста і в 20 км від аеропорту м Шарм-ель-Шейх. Загальна площа території готелю - 14200 кв. м. Рік побудови готелю - 2002 Остання реновація - 2018 р</td>
                                                </tr>
                                              <tr>
                                                <th scope = 'row'>Розміщення</th>
                                                   <td>
                                                     <span>Всього 127 номерів.</span>
                                                     <span>До розміщення пропонуються:<span>
                                                  <ul>
                                                    <li><strong>Standard</strong> (42 кв. М, двоспальне або 2 односпальні ліжка)</li>
                                                 </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>ванна кімната</li>
                                                    <li>фен</li>
                                                    <li>Wi-Fi</li>
                                                    <li>кондиціонер</li>
                                                    <li>ТВ</li>
                                                    <li>телефон</li>
                                                    <li>міні-бар (вода по заїзду))</li>
                                                    <li>балкон \ тераса</li>
                                                    <li>сейф</li>
                                                    <li>сервіс в номер (за додаткову плату)</li>
                                                 </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Територія</th>
                                                <td>
                                                  <ul>
                                                    <li>Wi-Fi в лобі (безкоштовно)</li>
                                                    <li>- послуги консьєржа</li>
                                                    <li>зберігання багажу</li>
                                                    <li>послуги лікаря (платно)</li>
                                                    <li>салон краси (платно)</li>
                                                    <li>магазини (платно)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'> Опис All Inclusive</th>
                                                <td>
                                                  Готель пропонує харчування по системі<b> All Inclusive:</b>
                                                  <ul>
                                                    <li>сніданок (07: 00-10: 00)</li>
                                                    <li>обід (13: 00-15: 00)</li>
                                                    <li>вечеря (19: 00-20: 30)</li>
                                                    <li>закуски в барі біля басейну (16: 00-17: 00)</li>
                                                    <li>місцеві алкогольні і безалкогольні напої, All Inclusive</li>
                                                  </ul>
                                               </td>
                                              <tr>
                                                <th scope = 'row'>Ресторани і бари</th>
                                                <td>
                                                 <ul>
                                                    <li>головний ресторан 'Panorama' (є відкрита літня тераса, міжнародна кухня; сніданок, обід і вечеря)</li>
                                                    <li>ресторан 'Tekia' (відкритий на обід і вечерю; платно)</li>
                                                    <li>бар 'Tekia' (10: 00-23: 00)</li>
                                                    <li>ресторан a la carte (італійська кухня; платно)</li>
                                                    <li>ресторан a la carte (морепродукти; платно)</li>
                                                    <li>бар 'La Pergola' (з 10:00 до заходу)</li>
                                                    <li>лобі-бар</li>
                                                    <li>паб (12: 00-03: 00; платно)</li>
                                                  </ul>
                                                  <p>Готель залишає за собою право вносити зміни в розклад роботи барів, кафе, ресторанів.</p>
                                                </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    Власний піщаний, в 15 хвилин їзди на трансфері від готелю.
                                    <p>Є кораловий риф.</p>
                                    <p>Є понтон</p>
                                    <p>Шаттл-бас до пляжу - безкоштовно, 4 рази на день.</p>
                                    <p>Пляжний інвентар - безкоштовно.</p>
                                    <p>Доступний пляж 'Шаркс бей' - платно (близько 5 $ \ чол. В день; діти до 12 років - безкоштовно), включаючи трансфер (2 рази на день).</p>
                                    <p>Пляжний інвентар - безкоштовно.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/hotels/egypt/sharm-el/sharm-el-1.jpg' /></p>
                                      <p>Різноманітність видів морських мешканців і сотні коралових рифів Червоного моря роблять Шарм-ель-Шейх особливо привабливим для любителів дайвінгу та еко-туризму. Заснована на туризмі економіка цього міста, розташованого на Синайському півострові, за останні кілька десятиліть пережила значний підйом, що стало причиною виникнення першокласних курортів і розквіту нічного життя.</p>
                                      <p>Серце всього Шарм-ель-Шейха - це Наама-Бей найяскравіший район курорту. Наама-Бей славиться своєю відмінною інфраструктурою. Тут є прогулянкова набережна, казино, безліч ресторанів, барів і кафе, розважальні клуби, нічні дискотеки, екскурсійні бюро та безліч інших закладів.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <ul>
                                                <li>відкритий басейн (1500 кв. М; з підігрівом взимку)</li>
                                                <li>3 водні гірки</li>
                                                <li>SPA-центр (платно)</li>
                                                <li>турецька лазня (платно)</li>
                                                <li>сауна (платно)</li>
                                                <li>джакузі (платно)</li>
                                                <li>масаж (платно)</li>
                                                <li>тренажерний зал</li>
                                                <li>більярд</li>
                                                <li>міні-футбол</li>
                                                <li>настільний теніс</li>
                                                <li>дартс</li>
                                                <li>водні види спорту на пляжі (платно)</li>
                                                <li>анімація</li>
                                              </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>2 дитячих відкритих басейни (підігріваються взимку)</li>
                                                <li>дитячий міні-клуб</li>
                                                <li>анімація для дітей</li>
                                                <li>міні-дискотека</li>
                                                <li>дитячі стільці в ресторані</li>
                                              </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в січні</h5>
                                    <p>Погода в січні в Шарм-ель-Шейху суха. Опади вірогідні, але якщо з неба і впадуть краплі, то цього ніхто не помітить. Якщо вдень стовпчик термометра дотягує до + 22 ° C, так само як і тіло акваторії; то після заходу ситуація змінюється. Термометр покаже тільки + 13 ° C. Погода в Шарм-ель-Шейху в січні не дасть розслабитися. Теплі речі Повинні занять почесне місце у валізі. Але нехтувати купальник не варто! У басейнах при готелях температура води незмінно річна. А в безвітряну погоду можна з комфортом поніжитися під сонцем біля моря. Головне пам'ятати, червоний прапор на пляжі - знак заборони на купання.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в лютому</h5>
                                    <p>Під кінець зимового періоду ситуація в Шарм-ель-Шейху мало відрізняється від попередньої їй. Море »подморожена». Його температура чи дотягує до двадцяти градусів за Цельсієм зі знаком плюс. Це погода в Шарм-ель-Шейху в лютому постаралася. Зате, якщо купання НЕ є Наріжним каменем подорожі, можна чудово провести час. В Єгипті чимало пам'ятки, яким НЕ насолодишся в високий сезон і під палючим сонцем. У світлий час доби погода в лютому в Шарм-ель-Шейху нагріє повітря до + 25 ° C в середньому. Після заходу стане в нагоді вітровка, за вікном буде всього + 17 ° C. Серед інших плюсів - відсутність дощів.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в березні</h5>
                                    <p>Поки що на березі комфортно тільки приймати сонячні ванни. Погода в Шрам-ель-Шейху в березні подбала лише про теплі навколо. У воді ж всього + 21 ° C! Зате на березі можна знемагати від спеки, температура повітря часом доходить до + 35 ° C. При таких успіхи, навіть море «відтане» на градус-другий. Середніми ж показниками прогріву повітря стануть + 24 ° C в світлий час доби і + 17 ° C після заходу сонця. Но погода в марте в Шарм-Эль-Шейхе достаточно динамична. И динамика эта положительна. То есть от декады к декаде будет жарче. При этом о дождях можно не беспокоиться, их вероятность сведена к минимуму. Но теплые вещи для вечерних прогулок и на случай сильного ветра (который непременно налетит) взять с собой рекомендуется.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в квітні</h5>
                                    <p>Погода в квітні в Шарм-ель-Шейху непередбачувана в вітро-плані. Так що, побоюватися варто «хамсин». Піщаний вихор налітає раптово, і також несподівано стихає. Теплі речі НЕ знадобляться вже і по ночах, прогретими до + 23 ° C в середньому. Зате довгий рукав або спеціальні засоби врятують від комарів, які можуть докучати відпочиваючим.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в травні</h5>
                                    <p>Погода в Шарм-ель-Шейху в травні Адекватне нікуди. Середньоденний тепло досягає + 34 ° C. З урахуванням кліматичної сухості, відчуття від такого режиму найприємніші. Головне не забувати користуватися кремом від сонця, промені його підступні. Ночами градусник термометра опускається до + 24 ° C. Заспокоюють вітру, а разом з ними і Акваторія, прогріта до + 26 ° C. Маленьким гостям курорту вже НЕ загрожують морські хвилювання. До речі, погода в травні в Шарм-ель-Шейху, кілька підступна. Мінусом штиль стануть комарі, варто подбати про захист.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в червні</h5>
                                    <p>Ось середніх + 37 ° C і до максимальних + 46 ° C - такий градусний розкид очікує біля берега Червоного моря. Погода в Шарм-ель-Шейху в червні все ще милосердна. Низький рівень вологості дозволяє дихати на повні груди, особливо після заходу сонця. Тоді градусник покаже всього + 26 ° C в середньому. А як нагрілося море! + 27 ° C - це коли в воді хочеться проводить годинник. І вся ця сіненебая безхмарність укупі з сухою, але все-таки спекою, може навіть набриднути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в липні</h5>
                                    <p>Погода в Шарм-ель-Шейху в червні дружить з цифрами за сорок. Добре, що в нічні години стовпчик термометра опускається до позначки в + 27 ° C в середньому. Але денні + 40 ° C і більше нікого тут НЕ дивуватися в цей час. Навіщо ж їхати в таке пекло, будучи в равом розумі? Погода в липні в Шарм-ель-Шейху знайшла відповідь. Низька вологість перетворює курорт в подобу сауни з сухою парою - жарко, але добре. Ось сонячного удару застрахує панама, тінь і своєчасну втечу в прохолоду кондиціонованих приміщень (зазвичай з полудня і до п'ятої вечора).</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в серпні</h5>
                                    <p>Обжигающий пісок, сліпуче сонце і соковита зелень навколо - таким буде Серпневий Шарм-ель-Шейх. Середньоденна температура досягає позначки в + 43 ° C! У такі моменти дякуєш винахідника кондиціонерів! Погода в Шарм-ель-Шейху в серпні немов піч. Особливо з полудня і до вечора. Якщо чесно, наслідках і ночами. Після заходу градусник демонструє + 30 ° C. За рахунок сухості клімату, навіть таке пекло терпимо. Акваторія, нагріта до + 29 ° C, завжди допоможе охолонути.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в вересні</h5>
                                    <p>Середньоденна температура знижується до + 38 ° C. Погода в Шарм-ель-Шейху в вересні набагато м'якше предидущемесячной. Нічна температура буде дорівнює середнім + 26 ° C. Тільки не потрібно чекати прохолоди в першій же декаді, вона буде скоріше схожа на серпневу ситуацію. Поспішати розлучатися з коштами від сонячних опіків і головних уборів Не варто. Акваторія анітрохи ні остигає, все той же + 29 ° C.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в жовтні</h5>
                                    <p>Погода в Шарм-ель-Шейху в жовтні знає відповідь. Пора в Єгипет! Доказів на користь цього напрямку маса. Море ще тепле, його температура дорівнює + 27 ° C. Турботливі службовці готелю навіть розчищають місцями захід у море від каменів! Залишається тільки насолоджуватися купання в солоній воді. Середньоденна температура досягає + 33 ° C. Вночі цифра змінюється на + 27 ° C. Таким чином, при світлі дня терпимо жарко, а після заходу сонця - саме те. А ще погода в жовтні в Шарм-ель-Шейху екскурсійно-адекватна. Взимку заважають вітру, влітку спека, а міжсезоння прекрасно підійде для знайомства з визначними пам'ятками.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в листопаді</h5>
                                    <p>Погода в Шарм-ель-Шейху в листопаді того підтвердження. Вдень температура тримається на середньому рівні в + 28 ° C. Ночами курорт остигає до + 19 ° C. замерзнути при такому розкладі складно, але можна. Все-таки пустеля колом, і тепла кофта повинна занять почесне місце в багажі (дуже стане в нагоді після заходу). Навіть море ще в тонусі, його тепло одно + 26 ° C, що цілком можна купатися. Погода в листопаді в Шарм-ель-Шейху буває і мокрою. Правда. Сумарна кількість осадом мізерно мало, а тому переживання в сторону.</p>
                                    <h5 class='text-secondary'>Погода в Шарм-ель-Шейху в грудні</h5>
                                    <p>Погода в Шарм-ель-Шейху в грудні різниться як раз по районному фактора. Проблема в властивих Єгипту зимових вітрах. Старт місяці - це середньоденні + 24 ° C, в цей час і море прогріти до комфортних + 25 ° C, і ночами досить кофтинки тепліше, щоб не змерзнути. У той же час днем ​​- тепло: можна позасмагати в своє задоволення або відправитися на екскурсію. На комфорті більш пізнього перебування позначиться розташування готелю. Ідеалом стане будь-яка з бухт - захищений від вітру пляж - щастя зимових туристів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
                }
            }
           );
            /*TIA Heights Makadi Bay 5 **/
            tourList.Add(
             new TourVM
             {
                 Id = 9,
                 Name = "Египт",
                 Start = new DateTime(2021, 7, 3, 14, 4, 5),
                 End = new DateTime(2021, 7, 10, 18, 5, 5),
                 DeparturePlace = "Київ",
                 ArivalFromPlace = "Макади Бэй",
                 FoodSupplyType = "все включено",
                 TravelerTypes = "1 дорослий",
                 PeopleCount = 1,
                 HotelStars = 5,
                 Costs = 11_645,
                 Carousel = new Carousel
                 {
                     ImgList = new List<CarouselImg>()
            {
                            new CarouselImg
                            {
                                Id = 0,
                                Src ="/images/hotels/egypt/tia-heights-makadi-bay-5/0.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/tia-heights-makadi-bay-5/0.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 1,
                                Src ="/images/hotels/egypt/tia-heights-makadi-bay-5/1.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/tia-heights-makadi-bay-5/1.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 2,
                                Src ="/images/hotels/egypt/tia-heights-makadi-bay-5/2.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/tia-heights-makadi-bay-5/2.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 3,
                                Src ="/images/hotels/egypt/tia-heights-makadi-bay-5/3.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/tia-heights-makadi-bay-5/3.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 4,
                                Src ="/images/hotels/egypt/tia-heights-makadi-bay-5/4.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/tia-heights-makadi-bay-5/4.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 5,
                                Src ="/images/hotels/egypt/tia-heights-makadi-bay-5/5.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/tia-heights-makadi-bay-5/5.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 6,
                                Src ="/images/hotels/egypt/tia-heights-makadi-bay-5/6.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/tia-heights-makadi-bay-5/6.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 7,
                                Src ="/images/hotels/egypt/tia-heights-makadi-bay-5/7.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/tia-heights-makadi-bay-5/7.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                            new CarouselImg
                            {
                                Id = 8,
                                Src ="/images/hotels/egypt/tia-heights-makadi-bay-5/8.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/tia-heights-makadi-bay-5/8.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 9,
                                Src ="/images/hotels/egypt/tia-heights-makadi-bay-5/9.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/tia-heights-makadi-bay-5/9.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },
                                new CarouselImg
                            {
                                Id = 10,
                                Src ="/images/hotels/egypt/tia-heights-makadi-bay-5/10.jpg",
                                Alt = "Hurghada",
                                DataRemote= "/images/hotels/egypt/tia-heights-makadi-bay-5/10.jpg",
                                DataType= "image",
                                DataToggle= "lightbox",
                                DataGallery= "example-gallery",
                            },

                   },
                     ThumbList = new List<CarouselThumb>()
            {
                            new CarouselThumb
                            {
                                Id = 0,
                                Src= "/images/hotels/egypt/tia-heights-makadi-bay-5/thumb/0.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 1,
                                Src= "/images/hotels/egypt/tia-heights-makadi-bay-5/thumb/1.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 2,
                                Src= "/images/hotels/egypt/tia-heights-makadi-bay-5/thumb/2.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 3,
                                Src= "/images/hotels/egypt/tia-heights-makadi-bay-5/thumb/3.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 4,
                                Src= "/images/hotels/egypt/tia-heights-makadi-bay-5/thumb/4.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 5,
                                Src= "/images/hotels/egypt/tia-heights-makadi-bay-5/thumb/5.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 6,
                                Src= "/images/hotels/egypt/amwaj-oyoun-resort-casino-5/thumb/6.jpg",
                                Alt = "Hurghada",
                            },
                            new CarouselThumb
                            {
                                Id = 7,
                                Src= "/images/hotels/egypt/tia-heights-makadi-bay-5/thumb/7.jpg",
                                Alt = "Hurghadah",
                            },
                            new CarouselThumb
                            {
                                Id = 8,
                                Src= "/images/hotels/egypt/tia-heights-makadi-bay-5/thumb/8.jpg",
                                Alt = "Hurghadah",
                            },
                             new CarouselThumb
                            {
                                Id = 9,
                                Src= "/images/hotels/egypt/tia-heights-makadi-bay-5/thumb/9.jpg",
                                Alt = "Hurghada",
                            },
                               new CarouselThumb
                            {
                                Id = 10,
                                Src= "/images/hotels/egypt/tia-heights-makadi-bay-5/thumb/10.jpg",
                                Alt = "Hurghada",
                            },
                   }
                 },
                 Services = new List<TourService>
        {
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#hotel",
                            Text = "Проживання в 2-х місному номері"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#public-transport",
                            Text = "Трансфер"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#food-serving",
                            Text = "Харчування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#safe",
                            Text = "Страхування"
                        },
                        new TourService
                        {
                            Img  = "/svg/sprite.svg#plane",
                            Text = "Переліт (авіакомпанія"
                        },
        },
                 InfoBlocks = new List<TourInfoBlock>
        {
                        new TourInfoBlock
                        {
                                Id =1,
                                NavName  = "hotel",
                                NavTitle= "Готель",
                                HtmlContent =
                                @"
                                    <div class='row'>
                                        <div class='col-sm-12 pt-3'>
                                          <p>Сучасний готель, розташований в бухті Макаді, пропонує гостям яскравий відпочинок і масу розваг. 17 водних гірок, величезний відкритий басейн, весела анімація та широкий вибір ресторанів на будь-який смак.</p>
                                          <table class='table table-striped'>
                                            <tbody>
                                               <tr>
                                                <th scope = 'row'>Розташування</th>
                                                <td>Готель розташований в бухті Макаді, на березі моря, в 25 км від міжнародного аеропорту м Хургада. Рік відкриття готелю - 1999 г. Остання реновація - 2018 р.</td>
                                                </tr>
                                              <tr>
                                                <th scope = 'row'>Розміщення</th>
                                                   <td>
                                                    <p>Готельний комплекс складає головної будівлі і корпусів 'Cascata'.</p>
                                                    <p>Всього 480 номерів.</p>
                                                   <span>До розміщення пропонуються:<span>
                                                  <ul>
                                                    <li><strong>Standard Aqua Park</strong> (номери розташовані близько аквапарку в корпусі 'Cascata', 30 кв. м., двоспальне або 2 односпальні ліжка)</li>
                                                    <li><strong>Standard Main Bulding</strong> (номери розташовані в головній будівлі, 34 кв. м., вид на сад)</li>
                                                   </ul>
                                                    <p>Більшість номерів мають суміжні двері.</p>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>У номері</th>
                                                <td>
                                                  <ul>
                                                    <li>ванна кімната з ванною</li>
                                                    <li>фен</li>
                                                    <li>туалетно-косметичні приналежності</li>
                                                    <li>кондиціонер</li>
                                                    <li>ТВ</li>
                                                    <li>телефон</li>
                                                    <li>Wi-Fi (платно)</li>
                                                    <li>сейф (безкоштовно)</li>
                                                    <li>міні-бар (не поповнюється)</li>
                                                    <li>прибирання номера (щодня)</li>
                                                   </ul>
                                                </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>Територія</th>
                                                <td>
                                                  <ul>
                                                    <li>Wi-Fi в лобі (безкоштовно)</li>
                                                    <li>парковка (безкоштовно)</li>
                                                    <li>конференц-зали (платно)</li>
                                                    <li>бізнес-центр (платно)</li>
                                                    <li>пральня (платно)</li>
                                                    <li>прокат автомобілів (платно)</li>
                                                    <li>послуги доктора (платно)</li>
                                                  </ul>
                                                </td>
                                              </tr>
                                               <th scope = 'row'>Ресторани і бари</th>
                                                <td>
                                                  <ul>
                                                    <li>головний ресторан 'Aladdin' (сніданок, обід, вечеря)</li>
                                                    <li>ресторан на пляжі 'La Caravan' (10: 30-17: 00)</li>
                                                    <li>ресторан a la carte (рибний; 19: 00-22: 00)</li>
                                                    <li>ресторан a la carte (італійська кухня; 19: 00-22: 00)</li>
                                                    <li>лобі-бар 'Dolphin' (24 години)</li>
                                                    <li>бар 'Dockers' (18: 00-02: 00)</li>
                                                    <li>бар 'Caravan' (10: 00-17: 00)'</li>
                                                  </ul> 
                                                <p>* Готель залишає за собою право вносити зміни в розклад роботи барів, кафе, ресторанів.</p>
                                               </td>
                                              </tr>
                                              <tr>
                                                <th scope = 'row'>•	Кредитні картки</th>
                                                <td>
                                                  <ul>
                                                    <li>Visa, MasterCard</li>
                                                  </ul> 
                                               </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </div>
                                      </div>
                                ",
                        },
                        new TourInfoBlock
                        {
                                Id = 2,
                                NavName  = "visit",
                                NavTitle= "Пляж",
                                HtmlContent =
                                @"
                                    <p>Власний піщанийВласний піщаний</p>
                                    <p>Перша берегова лінія.</p>
                                    <p>Протяжність - 560 м.</p>
                                    <p>Пляжний інвентар - безкоштовно.</p>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 3,
                                NavName  = "city",
                                NavTitle= "Про курорт (місто)",
                                HtmlContent =
                                @"
                                      <p class='pt-3'><img class='w-100' src='/images/hotels/egypt/sharm-el/sharm-el-1.jpg' /></p>
                                      <p>Різноманітність видів морських мешканців і сотні коралових рифів Червоного моря роблять Шарм-ель-Шейх особливо привабливим для любителів дайвінгу та еко-туризму. Заснована на туризмі економіка цього міста, розташованого на Синайському півострові, за останні кілька десятиліть пережила значний підйом, що стало причиною виникнення першокласних курортів і розквіту нічного життя.</p>
                                      <p>Серце всього Шарм-ель-Шейха - це Наама-Бей найяскравіший район курорту. Наама-Бей славиться своєю відмінною інфраструктурою. Тут є прогулянкова набережна, казино, безліч ресторанів, барів і кафе, розважальні клуби, нічні дискотеки, екскурсійні бюро та безліч інших закладів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 4,
                                NavName  = "fun",
                                NavTitle= "Розваги",
                                HtmlContent =
                                @"
                                    <table class='table table-striped '>
                                        <tbody>
                                          <tr>
                                            <th>Розваги і спорт</th>
                                            <td>
                                              <ul>
                                                <li>2 відкритих басейну</li>
                                                <li>водні гірки (для дорослих і дітей)</li>
                                                <li>тренажерний зал (безкоштовно)</li>
                                                <li>SPA-центр (платно)</li>
                                                <li>турецька лазня (платно)</li>
                                                <li>сауна (платно)</li>
                                                <li>масаж (платно)</li>
                                                <li>водні види спорту на пляжі (платно)</li>
                                               </ul>
                                             </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 5,
                                NavName  = "children",
                                NavTitle= "Для дітей",
                                HtmlContent =
                                @"
                                    <table class='table table-striped'>
                                        <tbody>
                                          <tr>
                                            <th>Для дітей</th>
                                            <td>
                                              <ul>
                                                <li>дитячий відкритий басейн</li>
                                                <li>дитячий міні-клуб</li>
                                                <li>дитячі стільці в ресторані</li>
                                                <li>дитяче ліжечко</li>
                                             </ul>
                                            </td>
                                          </tr>
                                        </tbody>
                                      </table>
                                "
                        },
                        new TourInfoBlock
                        {
                                Id = 6,
                                NavName  = "weather",
                                NavTitle= "Клімат",
                                HtmlContent =
                                @"
                                    <h4 class='text-info'>Клімат</h4>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в січні</h5>
                                    <p>Погода в січні в Хургаді (Макади Бэй) суха. Опади вірогідні, але якщо з неба і впадуть краплі, то цього ніхто не помітить. Якщо вдень стовпчик термометра дотягує до + 22 ° C, так само як і тіло акваторії; то після заходу ситуація змінюється. Термометр покаже тільки + 13 ° C. Погода в Хургаді (Макади Бэй)в січні не дасть розслабитися. Теплі речі Повинні занять почесне місце у валізі. Але нехтувати купальник не варто! У басейнах при готелях температура води незмінно річна. А в безвітряну погоду можна з комфортом поніжитися під сонцем біля моря. Головне пам'ятати, червоний прапор на пляжі - знак заборони на купання.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в лютому</h5>
                                    <p>Під кінець зимового періоду ситуація в Хургаді (Макади Бэй) мало відрізняється від попередньої їй. Море »подморожена». Його температура чи дотягує до двадцяти градусів за Цельсієм зі знаком плюс. Це погода в Хургаді (Макади Бэй) в лютому постаралася. Зате, якщо купання НЕ є Наріжним каменем подорожі, можна чудово провести час. В Єгипті чимало пам'ятки, яким НЕ насолодишся в високий сезон і під палючим сонцем. У світлий час доби погода в лютому в Хургаді (Макади Бэй) нагріє повітря до + 25 ° C в середньому. Після заходу стане в нагоді вітровка, за вікном буде всього + 17 ° C. Серед інших плюсів - відсутність дощів.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в березні</h5>
                                    <p>Поки що на березі комфортно тільки приймати сонячні ванни. Погода в Шрам-ель-Шейху в березні подбала лише про теплі навколо. У воді ж всього + 21 ° C! Зате на березі можна знемагати від спеки, температура повітря часом доходить до + 35 ° C. При таких успіхи, навіть море «відтане» на градус-другий. Середніми ж показниками прогріву повітря стануть + 24 ° C в світлий час доби і + 17 ° C після заходу сонця. Но погода в марте в Шарм-Эль-Шейхе достаточно динамична. И динамика эта положительна. То есть от декады к декаде будет жарче. При этом о дождях можно не беспокоиться, их вероятность сведена к минимуму. Но теплые вещи для вечерних прогулок и на случай сильного ветра (который непременно налетит) взять с собой рекомендуется.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в квітні</h5>
                                    <p>Погода в квітні в Хургаді (Макади Бэй) непередбачувана в вітро-плані. Так що, побоюватися варто «хамсин». Піщаний вихор налітає раптово, і також несподівано стихає. Теплі речі НЕ знадобляться вже і по ночах, прогретими до + 23 ° C в середньому. Зате довгий рукав або спеціальні засоби врятують від комарів, які можуть докучати відпочиваючим.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в травні</h5>
                                    <p>Погода в Хургаді (Макади Бэй) в травні Адекватне нікуди. Середньоденний тепло досягає + 34 ° C. З урахуванням кліматичної сухості, відчуття від такого режиму найприємніші. Головне не забувати користуватися кремом від сонця, промені його підступні. Ночами градусник термометра опускається до + 24 ° C. Заспокоюють вітру, а разом з ними і Акваторія, прогріта до + 26 ° C. Маленьким гостям курорту вже НЕ загрожують морські хвилювання. До речі, погода в травні в Хургаді (Макади Бэй), кілька підступна. Мінусом штиль стануть комарі, варто подбати про захист.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в червні</h5>
                                    <p>Ось середніх + 37 ° C і до максимальних + 46 ° C - такий градусний розкид очікує біля берега Червоного моря. Погода в Хургаді (Макади Бэй) в червні все ще милосердна. Низький рівень вологості дозволяє дихати на повні груди, особливо після заходу сонця. Тоді градусник покаже всього + 26 ° C в середньому. А як нагрілося море! + 27 ° C - це коли в воді хочеться проводить годинник. І вся ця сіненебая безхмарність укупі з сухою, але все-таки спекою, може навіть набриднути.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в липні</h5>
                                    <p>Погода в Хургаді (Макади Бэй) в червні дружить з цифрами за сорок. Добре, що в нічні години стовпчик термометра опускається до позначки в + 27 ° C в середньому. Але денні + 40 ° C і більше нікого тут НЕ дивуватися в цей час. Навіщо ж їхати в таке пекло, будучи в равом розумі? Погода в липні в Хургаді (Макади Бэй) знайшла відповідь. Низька вологість перетворює курорт в подобу сауни з сухою парою - жарко, але добре. Ось сонячного удару застрахує панама, тінь і своєчасну втечу в прохолоду кондиціонованих приміщень (зазвичай з полудня і до п'ятої вечора).</p>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в серпні</h5>
                                    <p>Обжигающий пісок, сліпуче сонце і соковита зелень навколо - таким буде Серпневий Шарм-ель-Шейх. Середньоденна температура досягає позначки в + 43 ° C! У такі моменти дякуєш винахідника кондиціонерів! Погода в Хургаді (Макади Бэй) в серпні немов піч. Особливо з полудня і до вечора. Якщо чесно, наслідках і ночами. Після заходу градусник демонструє + 30 ° C. За рахунок сухості клімату, навіть таке пекло терпимо. Акваторія, нагріта до + 29 ° C, завжди допоможе охолонути.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в вересні</h5>
                                    <p>Середньоденна температура знижується до + 38 ° C. Погода в Хургаді (Макади Бэй) в вересні набагато м'якше предидущемесячной. Нічна температура буде дорівнює середнім + 26 ° C. Тільки не потрібно чекати прохолоди в першій же декаді, вона буде скоріше схожа на серпневу ситуацію. Поспішати розлучатися з коштами від сонячних опіків і головних уборів Не варто. Акваторія анітрохи ні остигає, все той же + 29 ° C.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в жовтні</h5>
                                    <p>Погода в Хургаді (Макади Бэй) в жовтні знає відповідь. Пора в Єгипет! Доказів на користь цього напрямку маса. Море ще тепле, його температура дорівнює + 27 ° C. Турботливі службовці готелю навіть розчищають місцями захід у море від каменів! Залишається тільки насолоджуватися купання в солоній воді. Середньоденна температура досягає + 33 ° C. Вночі цифра змінюється на + 27 ° C. Таким чином, при світлі дня терпимо жарко, а після заходу сонця - саме те. А ще погода в жовтні в Хургаді (Макади Бэй) екскурсійно-адекватна. Взимку заважають вітру, влітку спека, а міжсезоння прекрасно підійде для знайомства з визначними пам'ятками.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в листопаді</h5>
                                    <p>Погода в Хургаді (Макади Бэй) в листопаді того підтвердження. Вдень температура тримається на середньому рівні в + 28 ° C. Ночами курорт остигає до + 19 ° C. замерзнути при такому розкладі складно, але можна. Все-таки пустеля колом, і тепла кофта повинна занять почесне місце в багажі (дуже стане в нагоді після заходу). Навіть море ще в тонусі, його тепло одно + 26 ° C, що цілком можна купатися. Погода в листопаді в Хургаді (Макади Бэй) буває і мокрою. Правда. Сумарна кількість осадом мізерно мало, а тому переживання в сторону.</p>
                                    <h5 class='text-secondary'>Погода в Хургаді (Макади Бэй) в грудні</h5>
                                    <p>Погода в Хургаді (Макади Бэй) в грудні різниться як раз по районному фактора. Проблема в властивих Єгипту зимових вітрах. Старт місяці - це середньоденні + 24 ° C, в цей час і море прогріти до комфортних + 25 ° C, і ночами досить кофтинки тепліше, щоб не змерзнути. У той же час днем ​​- тепло: можна позасмагати в своє задоволення або відправитися на екскурсію. На комфорті більш пізнього перебування позначиться розташування готелю. Ідеалом стане будь-яка з бухт - захищений від вітру пляж - щастя зимових туристів.</p>
                                 "
                        },
                        new TourInfoBlock
                        {
                                Id = 7,
                                NavName  = "addition",
                                NavTitle= "Додатково (потрібно знати)",
                                HtmlContent =
                                @"
                                    <h4 class='text-danger'>Важливо!</h4>
                                    <p>
                                        Шановні туристи дякую Вам за уважність до цієї інформації. Наша компанія хотіла би зупинитися на деяких моментах данного туристичного продукту. Наша основна мете задовільнити туриста під час перебування його на відпочинку, а також залишити позитивні враження після поверення його до домому, відтак:
                                        <h4>Щодо недоліків:</h4>
                                        <ul>
                                          <li> будь ласка памятайте, що в готелях не видають одноразову постільну білизну тільки випране та випрасуване;</li>
                                          <li> будь ласка перед придбанням данного туристичного продукту перегляньте уважно всю інформацію щодо готелю та місця розташування задля уникнення непорозумінь у випадку відсутності якоїсь послуги;</li>
                                          <li> якщо Ви бажаєте знати про недоліки, які можуть Вас супроводжувати під час відпочинку, політика нашої компанії повідомити про це туриста.</li>
                                        </ul>
                                     </p>
                                "
                        },
               }
             }
         );
            return tourList.FirstOrDefault(x => x.Id == id);
        }
    }
}
