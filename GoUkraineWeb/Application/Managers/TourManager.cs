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

            return tourList.FirstOrDefault(x => x.Id == id);
        }
    }
}
