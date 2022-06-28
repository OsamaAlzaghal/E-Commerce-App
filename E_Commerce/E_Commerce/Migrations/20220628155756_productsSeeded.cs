using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce.Migrations
{
    public partial class productsSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "PCs And Laptops");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 2, "SUPERIOR DYNAMIC QUALITY | Milan delivers 5.1 surround sound using uncompressed 24-bit 48 kHz audio signal (Milan delivers 3.1 sound using uncompressed 24-bit 48 kHz audio signal), far beyond Bluetooth capabilities. The SoundSend transmitter decodes theatrical audio formats, such as Dolby HD and Dolby Atmos.", "Platin Milan 5.1 Wireless Home Theater System", 899.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 2, "SUBWOOFER INCLUDED - Wireless subwoofer is included so you can enjoy deep bass right out of the box All-in-one|| BASS BOOST - Give your bass an instant boost with the push of a button on the soundbar", "Samsung HW-A450/ZA 2.1ch Soundbar with Dolby Audio (2021) , Black", 147.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Low-Profile Design and Brilliant Clarity with 6 Full-range Speakers||Powerful 5-Inch Wireless Subwoofer and Bluetooth Music Streaming||Complete Immersion with Discreet Volume Adjustable Surround Speakers||Optimized for 4K TVs with Dolby Audio 5.1 and HDMI(Cable Included)||Control with TV Remote using HDMI, Audio Cables Included for Easy Setup", "Vizio V51x-J6 36-inch 5.1 Channel Home Theater Soundbar System (Renewed)", 169.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "5.1 digital surround sound: Hear every detail in your Dolby Digital and DTS soundtracks the way the studio intended. Sub woofer: 165 Watts||THX certified home theater speakers: Your assurance of true cinema quality sound.Satellites : 4 x 67 W,  wall mountable||Delivers a continuous 500 watts of power, with the ability to deliver a peak of 1000 watts under certain circumstances: Thunderous, room shaking audio with deep bass you can feel", "Logitech Z906 5.1 Surround Sound Speaker System - THX, Dolby Digital and DTS Digital Certified - Black", 351.49000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 2, "Bluetooth 5. 1 Home Theater Speaker System - Stream Music From Your Phone To The Built In Bluetooth Receiver, Integrated Power Amp With 700 Watts System Power, Pro Surround Function Automatically Converts Stereo To 5. 1 Sound, Fm Tuner", "Acoustic Audio AA5172 700W Bluetooth Home Theater 5.1 Speaker System with FM Tuner, USB, SD Card, Remote Control, Powered Sub (6 Speakers, 5.1 Channels, Black with Gray)", 114.88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 2, "DOLBY ATMOS / DTS:X - Theater-quality sound that fires from the front, side and above for true audio immersion.TRUE 3.1.2CH SOUND - The complete audio entertainment experience with 3 channels,  1 subwoofer and 2 up - firing channels.", "SAMSUNG 3.1.2ch Q700A Q Series Soundbar - Dolby Atmos/ DTS: X (HW-Q700A, 2021 Model), Black", 547.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CategoryID", "Description", "InStock", "Name", "Price" },
                values: new object[] { 2, "Wireless Water-Resistant Speaker with Long-Lasting Battery and Handle, Black More sound all around—Engineered to deliver true 360° sound for consistent, uniform coverage from a bluetooth speaker. SoundLink Revolve II plays louder and deeper with longer battery life than SoundLink Revolve II", true, "Bose SoundLink Revolve+ (Series II) Portable Bluetooth Speaker ", 329.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CategoryID", "Description", "Name", "Price", "URL" },
                values: new object[] { 2, "POWERFUL JBL ORIGINAL PRO SOUND: Feel your music. Flip 5's all new racetrack-shaped driver delivers bold JBL signature sound. Enjoy booming bass in a small package.", "JBL FLIP 5, Waterproof Portable Bluetooth Speaker, Blue", 99.950000000000003, "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CartID", "CategoryID", "Description", "InStock", "Name", "Price", "URL" },
                values: new object[,]
                {
                    { 87, null, 4, "6.7-Inch Super Retina XDR display with ProMotion. 5G Superfast downloads,high ? quality streamingCinematic mode in 1080p at 30 fps.Dolby Vision HDR video recording up to 4K at 60 fps. 6X Optical zoom rangeA15 Bionic chip.New 6 - core CPU with 2 performance and 4 efficiency cores.New 5 - core GPU.New 16 - core Neural EngineUp to 28 hours video playback.Face ID.Ceramic Shield front.Surgical - grade stainless steelWater resistant to a depth of 6 meters for up to 30 minutes.Compatible with MagSafe accessories and wireless chargers", true, "Apple iPhone 13 Pro Max, 128GB, Graphite - Unlocked (Renewed)", 1147.95, "" },
                    { 71, null, 4, "Factory Unlocked Android Smartphone, 128GB, 6.5” FHD Super AMOLED Screen, Long Battery Life, US Version, Black", true, "SAMSUNG Galaxy A53 5G A Series Cell Phone", 449.99000000000001, "" },
                    { 72, null, 4, "This phone is unlocked and compatible with any carrier of choice on GSM and CDMA networks (e.g. AT&T, T-Mobile, Sprint, Verizon, US Cellular, Cricket, Metro, Tracfone, Mint Mobile, etc.).", true, "Apple iPhone 11, 64GB, Black - Unlocked (Renewed)", 339.0, "" },
                    { 73, null, 4, "This phone is unlocked and compatible with any carrier of choice on GSM and CDMA networks (e.g. AT&T, T-Mobile, Sprint, Verizon, US Cellular, Cricket, Metro, Tracfone, Mint Mobile, etc.).", true, "Apple iPhone XR, 64GB, Black - Unlocked (Renewed)", 231.99000000000001, "" },
                    { 74, null, 4, "This phone is unlocked and compatible with any carrier of choice on GSM and CDMA networks (e.g. AT&T, T-Mobile, Sprint, Verizon, US Cellular, Cricket, Metro, Tracfone, Mint Mobile, etc.).", true, "Samsung Galaxy S10, 128GB, Prism Black - Unlocked (Renewed)", 322.57999999999998, "" },
                    { 75, null, 4, "Fully Unlocked: Fully unlocked and compatible with any carrier of choice (e.g. AT&T, T-Mobile, Sprint, Verizon, US-Cellular, Cricket, Metro, etc.), both domestically and internationally.", true, "Samsung Galaxy S10e, 128GB, Prism Black - Unlocked (Renewed)", 170.0, "" },
                    { 76, null, 4, "Factory Unlocked Android smartphone, 256GB, 8K Camera & Video, Brightest Display Screen, S Pen, Long Battery Life, Fast 4nm Processor, US Version, Phantom Black", true, "SAMSUNG Galaxy S22 Ultra Cell Phone", 1049.99, "" },
                    { 77, null, 4, "Android Phone - Unlocked Smartphone with Wide and Ultrawide Lens - 128GB - Stormy Black", true, "Google Pixel 6 – 5G", 599.0, "" },
                    { 88, null, 4, "This phone is unlocked and compatible with any carrier of choice on GSM and CDMA networks (e.g. AT&T, T-Mobile, Sprint, Verizon, US Cellular, Cricket, Metro, Tracfone, Mint Mobile, etc.).", true, "Apple iPhone 11 Pro, 64GB, Space Gray - Unlocked (Renewed)", 459.13999999999999, "" },
                    { 78, null, 4, "5G Android Smartphone | 6.7” QHD+ Display | 12GB+256GB | U.S. Unlocked | Triple Camera co-Developed with Hasselblad | Volcanic Black", true, "OnePlus 10 Pro", 969.99000000000001, "" },
                    { 80, null, 4, "256GB, Aura Black - Fully Unlocked (Renewed) Fully Unlocked: Fully unlocked and compatible with any carrier of choice (e.g. AT&T, T-Mobile, Sprint, Verizon, US-Cellular, Cricket, Metro, etc.), both domestically and internationally.", true, "Samsung Galaxy Note 10", 287.0, "" },
                    { 81, null, 4, "256GB, Aura Black - Fully Unlocked (Renewed) Fully Unlocked: Fully unlocked and compatible with any carrier of choice (e.g. AT&T, T-Mobile, Sprint, Verizon, US-Cellular, Cricket, Metro, etc.), both domestically and internationally.", true, "Samsung Galaxy Note 10+", 342.0, "" },
                    { 82, null, 4, "This phone is unlocked and compatible with any carrier of choice on GSM and CDMA networks (e.g. AT&T, T-Mobile, Sprint, Verizon, US Cellular, Cricket, Metro, Tracfone, Mint Mobile, etc.).", true, "Apple iPhone 12, 64GB, Blue - Fully Unlocked (Renewed)", 1049.99, "" },
                    { 70, null, 3, "SMART HUB: Access to Streaming apps like Netflix, YouTube, Apple TV, Disney + and local OTT|| IMPROVED CONNECTIVITY: USB - C offers a single connection architecture for a clutter-free and stress - free environment; Wirelessly connect to and mirror PCs remotely on the Smart Monitor for a PC-less environment.", true, "SAMSUNG M8 Series 32-Inch 4K UHD Smart Monitor & Streaming TV with Slim-fit Webcam (LS32BM801UNXGO)", 699.99000000000001, "" },
                    { 84, null, 4, "6.1-inch Super Retina XDR displayCinematic mode adds shallow depth of field and shifts focus automatically in your videosAdvanced dual - camera system with 12MP Wide and Ultra Wide cameras; Photographic Styles, Smart HDR 4, Night mode, 4K Dolby Vision HDR recording12MP TrueDepth front camera with Night mode, 4K Dolby Vision HDR recordingA15 Bionic chip for lightning - fast performance", true, "Apple iPhone 13 (256GB, Blue) [Locked]", 929.0, "" },
                    { 85, null, 4, "6.1-inch Super Retina XDR display with ProMotion for a faster, more responsive feelCinematic mode adds shallow depth of field and shifts focus automatically in your videosPro camera system with new 12MP Telephoto, Wide, and Ultra Wide cameras; LiDAR Scanner; 6x optical zoom range; macro photography; Photographic Styles, ProRes video, Smart HDR 4, Night mode, Apple ProRAW, 4K Dolby Vision HDR recording12MP TrueDepth front camera with Night mode, 4K Dolby Vision HDR recordingA15 Bionic chip for lightning - fast performanceUp to 22 hours of video playbackDurable design with Ceramic Shield", true, "Apple iPhone 13 Pro (512GB, Graphite) [Locked]", 1299.0, "" },
                    { 86, null, 4, "5.4-inch Super Retina XDR display Cinematic mode adds shallow depth of field and shifts focus automatically in your videosAdvanced dual - camera system with 12MP Wide and Ultra Wide cameras; Photographic Styles, Smart HDR 4, Night mode, 4K Dolby Vision HDR recording12MP TrueDepth front camera with Night mode, 4K Dolby Vision HDR recordingA15 Bionic chip for lightning - fast performanceUp to 17 hours of video playbackDurable design with Ceramic Shield", true, "Apple iPhone 13 Mini (128GB, Starlight) [Locked]", 729.0, "" },
                    { 79, null, 4, "5G Cell Phone, Factory Unlocked Android Smartphone, 128GB, Pro Grade Camera, 30X Space Zoom, Night Mode, US Version, Cloud Navy", true, "SAMSUNG Galaxy S20 FE", 599.99000000000001, "" },
                    { 83, null, 4, "*Charging Cube is Not Included*, 6.5-Inch,Super AMOLED,  120Hz,  800 nits,1080x2400 pixels, 5000mAh Battery128GB ROM,   6GB RAM,  Exynos 1280(5 nm), Octa - core,  Mali - G68,Android 12,One UI 4.1|| Rear Camera: 64MP, f / 1.8 + 12MP, f / 2.2 + 5MP,   f / 2.4 + 5MP, f / 2.4,Front Camera: 32MP,f / 2.2", true, "Samsung Galaxy A53 5G (SM-A536E/DS)", 320.00999999999999, "" },
                    { 69, null, 3, "4K UltraHD delivers more than four times the resolution of a regular 1080p highdefinition screen. Along with over 8.3 million pixels, inside you'll find a powerful full array LED backlight at work creating a sharper, more colorful picture.", true, "Hisense 55-Inch Class R6 Series Dolby Vision HDR 4K UHD Roku Smart TV with Alexa Compatibility (55R6G, 2021 Model)", 449.94999999999999, "" },
                    { 67, null, 3, "4K Ultra High Definition: More pixels on the screen produces a more clear and succinct picture making content look more realistic and true to life. Combined with Hisense's AI UHD Upscaler , non 4K content will get enhanced to near 4K quality.", true, "Hisense A6 Series 55-Inch 4K UHD Smart Google TV (55A6H, 2022 New Model)", 319.99000000000001, "" },
                    { 42, null, 2, "Portable Mini Bluetooth Speaker, Big Audio and Punchy bass, Integrated Carabiner, IP67 Waterproof and dustproof, 10 Hours of Playtime, Speaker for Home, Outdoor and Travel - (Blue)", true, "JBL Clip 4", 79.950000000000003, "" },
                    { 43, null, 2, "WIRELESS BLUETOOTH STREAMING: Wirelessly connect up to 2 smartphones or tablets to the speaker and take turns enjoying powerful sound.||UP TO 20 HOURS OF PLAYTIME: Built -in rechargeable Li - ion 7500mAH battery supports up to 20 hours of playtime and charges your device via USB port|| IPX7 WATERPROOF: Take Charge 4 to the beach or the pool without worrying about spills or even submersion in water", true, "JBL Charge 4 - Waterproof Portable Bluetooth Speaker - Black", 113.95, "" },
                    { 44, null, 2, "Portable Bluetooth Speaker, Powerful Sound and Deep Bass, IP67 Waterproof, 15 Hours of Playtime, Powerbank, JBL PartyBoost for Multi-speaker Pairing (Black)", true, "JBL Xtreme 3", 299.94999999999999, "" },
                    { 45, null, 2, "River Teal - Waterproof, Durable & Portable Bluetooth Speaker - Up to 10 Hours of Play - Includes Noise-Cancelling Speakerphone & Wireless Streaming", true, "JBL Clip 3", 39.950000000000003, "" },
                    { 46, null, 2, "State-of-the-art design – SoundLink Flex outdoor speaker is packed with exclusive technologies and a custom-engineered transducer for deep, clear, and immersive audio at home or on the go", true, "Bose SoundLink Flex Bluetooth Portable Speaker, Wireless Waterproof Speaker for Outdoor Travel - Black", 149.0, "" },
                    { 47, null, 2, "DAZZLING 360 DEGREES LED LIGHTS: Pulse 4 shines through the night with an amazing, high-resolution 360-degree LED lightshow.||POWERFUL JBL ORIGINAL PRO SOUND: Pulse 4 delivers JBL Signature Sound in every direction with its ingenious 360 degree speaker array.", true, "JBL Pulse 4 - Waterproof Portable Bluetooth Speaker with Light Show - Black", 249.94999999999999, "" },
                    { 48, null, 2, "IP67 Waterproof & Durable for Home, Outdoor, and Travel, 24 Hour Battery, Party Lights, USB Type-C, and Speakerphone, Black||Boost your music with 2 speaker lights and multi-colored line lights and turn the lights on or off via the Fiestable App", true, "Sony SRS-XB43 EXTRA BASS Wireless Bluetooth Powerful Portable Speaker", 178.0, "" },
                    { 49, null, 3, "BRAVIA XR Full Array LED Smart Google TV with Dolby Vision HDR and Exclusive Features for The Playstation® 5 XR65X90K- 2022 Model", true, "Sony 65 Inch 4K Ultra HD TV X90K Series", 1298.0, "" },
                    { 50, null, 3, "CT-2860 High Definition Television 720p 60Hz TV, Lightweight and Slim Design, VGA/HDMI/USB Inputs, VESA Wall Mount Compatible.", true, "28” LED HDTV by Continu.us", 249.0, "" },
                    { 51, null, 3, "Brilliant 4K entertainment - Bring movies and shows to life with support for vivid 4K Ultra HD, HDR 10, HLG, and Dolby Digital Plus, and control the TV hands-free with Alexa.", true, "Amazon Fire TV 55inch", 299.0, "" },
                    { 52, null, 3, "4K Ultra HD, HDR 10, and HLG deliver a clearer and more vibrant picture with brighter colors compared to 1080p Full HD.", true, "Amazon Fire TV 50inch 4 - Series 4K UHD smart TV", 469.99000000000001, "" },
                    { 53, null, 3, "4K UHD HDR Smart TV with Alexa Built-in (UN65AU8000FXZA, 2021 Model), Black", true, "SAMSUNG 65-Inch Class Crystal UHD AU8000 Series", 647.0, "" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CartID", "CategoryID", "Description", "InStock", "Name", "Price", "URL" },
                values: new object[,]
                {
                    { 54, null, 3, "Smart functionality delivers all your favorite content with over 500,000 movies and TV episodes, accessible through the simple and intuitive Roku TV |HD, Resolution: High definition (720p) resolution for excellent detail, color and contrast. Wireless Connection : 802.11ac 1x1 Dual Band", true, "TCL 32-inch 3-Series 720p Roku Smart TV - 32S335, 2021 Model", 158.0, "" },
                    { 55, null, 3, "1080p Full HD Resolution excellent detail, color, and contrast. Wireless Connection: 802.11 2x2 Dual Band || Direct-lit LED produces great picture quality with 60Hz refresh rate for fast moving action scenes with virtually no motion blur. Screw Size : M4 x 8", true, "TCL 32-inch 1080p Roku Smart LED TV - 32S327, 2019 Model", 168.0, "" },
                    { 56, null, 3, "Full Array Local Dimming - The M550 backlight panel with full array local dimming. This technology separates the LEDs into smaller, more tightly controlled lighting areas giving the television more control over the parts of the picture that need more or less lighting without affecting the other areas.", true, "Toshiba 55-inch Class M550 Series LED 4K UHD Smart Fire TV with Hands-Free with Alexa (55M550KU, 2021 Model)", 799.99000000000001, "" },
                    { 57, null, 3, "Full HD 1080p Resolution|| PurColor|| Micro Dimming Pro|| Samsung Smart TV.Mini Wall Mount and Vesa Wall Mount Compatible|| SmartThings App Support.Product Size(W x H x D) Without Stand - 36.3 x 20.9 x 2.9 inches.Stand Size(WxHxD) - 5.2 x 5.6 x 6.7 inches", true, "SAMSUNG 40-inch Class LED Smart FHD TV 1080P (UN40N5200AFXZA, 2019 Model)", 227.99000000000001, "" },
                    { 58, null, 3, "Full HD (1080p) Resolution: Full high definition (1080p) resolution for excellent detail, color, and contrast.|| Google Assistant Built -in: Search for movies and shows across thousands of available apps, get entertainment recommendations, access media playback controls, change the temperature, dim the lights, and so much more.Ask questions and see the answers on your TV, including Google Photos, your calendar, sports scores, and more.Even automate and control your smart devices.The Google Assistant is always on, ready to help, and makes life in your living room that much more relaxing.", true, "TCL 40-inch Class 3-Series HD LED Smart Android TV - 40S334, 2021 Model", 198.0, "" },
                    { 59, null, 3, "1080p High-Definition - Watch TV in crisp, clear 1080p Full HD resolution and experience a brilliant picture with the VIZIO D-Series.|| Full Array LED Backlight - Evenly distributed LEDs across the screen’s backlight deliver superior light uniformity and picture performance.", true, "VIZIO 32-inch D-Series Full HD 1080p Smart TV with Apple AirPlay and Chromecast Built-in, Alexa Compatibility, D32f-J04, 2021 Model", 163.65000000000001, "" },
                    { 60, null, 3, "INTELLIGENT TV PROCESSING– The 4K HDR Processor X1 delivers a picture that is smooth and clear, full of rich colors and detailed contrast.|| WIDE SPECTRUM OF COLORS - Reproduces over a billion accurate colors resulting in picture quality that is natural and precise,and closer than ever to real life,enhanced by TRILUMINOS Pro.", true, "Sony 65 Inch 4K Ultra HD TV X80K Series: LED Smart Google TV with Dolby Vision HDR KD65X80K- 2022 Model", 798.0, "" },
                    { 61, null, 3, "ULTRA-BRIGHT FOR THE OUTDOORS – The high brightness you need outside with an advanced 1,000 nit screen. Full Array Local zone dimming for brighter brights and darker darks. IP55-rated aluminum exterior made for the elements – including rain & snow.", true, "SunBrite Veranda 3 Series 55-inch Full Shade Outdoor Smart TV (2022) | 4K Ultra HD HDR LED Weatherproof Television - 1,000 nit Ultra Bright Screen SB-V3-55-4KHDR-BL", 2898.9499999999998, "" },
                    { 62, null, 3, "1080p resolution View your favorite movies, shows and games in high definition. || Alexa voice control - The Alexa Voice Remote lets you easily control your entertainment,search across apps, switch inputs, and more using just your voice.Press and hold the voice button and ask Alexa to easily find, launch, and control content, and even switch to cable.", true, "Insignia 32-inch Class F20 Series Smart Full HD 1080p Fire TV (NS-32F202NA22, 2021 Model)", 199.99000000000001, "" },
                    { 63, null, 3, "Stunning 4K Ultra HD: 4K resolution delivers stunning detail and remarkable visual experience.|| High Dynamic Range: HDR delivers bright and accurate colors for a lifelike viewing experience.|| Google Assistant Built -in", true, "TCL 50-inch Class 4-Series 4K UHD HDR Smart Android TV - 50S434, 2021 Model", 317.99000000000001, "" },
                    { 64, null, 3, "High Dynamic Range: HDR delivers bright and accurate colors for a lifelike viewing experience.|| Stunning 4K Ultra HD: 4K resolution delivers stunning detail and a remarkable visual experience.|| Easy Voice Control", true, "TCL 75-inch Class 4-Series 4K UHD HDR Smart Roku TV – 75S435, 2021 Model", 699.99000000000001, "" },
                    { 65, null, 3, "CRYSTAL PROCESSOR 4K: This ultra fast processor transforms everything you watch into stunning 4K.|| MOTION RATE 240: Minimizes motion blur on screen,so action packed movies and sports stay smooth and crisp.|| SMART TV POWERED BY TIZEN TM: Go beyond Smart TV with next gen apps, super easy control,and a host of enhancements that elevate the TV watching experience.", true, "SAMSUNG 85-Inch Class Crystal 4K UHD AU8000 Series HDR Smart TV (UN85AU8000FXZA, 2021 Model)", 1597.99, "" },
                    { 66, null, 3, "Regza Engine 4K is Toshiba’s high performance 4K engine for stunning picture quality, with ultra essential PQ technology combined with high quality LCD panel, you can get an incredible ultra HD 4K images with breath-taking picture quality.", true, "Toshiba 43-inch Class C350 Series LED 4K UHD Smart Fire TV (43C350KU, 2021 Model)", 329.99000000000001, "" },
                    { 68, null, 3, "Stunning 4K Ultra HD: 4K resolution delivers stunning detail and remarkable visual experience.|| High Dynamic Range: HDR delivers bright and accurate colors for a lifelike viewing experience.", true, "TCL 55-Inch Class 4 - Series 4K UHD HDR Smart Google TV – 55S446, 2022 Model", 339.99000000000001, "" },
                    { 41, null, 2, "IP67 Waterproof & Durable for Outdoor, 16 Hour Battery, USB Type-C, Removable Strap, & Speakerphone, Light Blue || EXTRA BASS for deep, punchy sound", true, "Sony SRS-XB13 EXTRA BASS Wireless Bluetooth Portable Lightweight Compact Travel Speaker", 48.0, "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "PC && Laptops");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 1, "A descktop pc with great performance", "iMac Retina", 1500.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 1, "Dell OptiPlex 7780 All-in-One 10Gen Intel Core i7 up to 4.8GHz 16M 6-Cores , 8GB RAM DDR4 (upgradable) , 256 GB Gen 3 PCIe x4 NVMe SSD + 1TB HDD , 27inch WVA Full HD 250nits Screen, NO Optical Drive,Intel UHD 630 Graphic Card,", "Dell OptiPlex 7780 All-in-One All-in-One 10Gen Intel Core i7 w/ Adjustable 27inch Touch", 1000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "5.1 digital surround sound: Hear every detail in your Dolby Digital and DTS soundtracks the way the studio intended. Sub woofer: 165 Watts", "Logitech Z906 5.1 Surround Sound Speaker System THX, Dolby Digital & DTS Digital Certified", 100.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "High performance speaker system that produces 50 Watts of raw, rock solid audio power", "Creative SBS E2800 2.1 High Performance Speakers System - Black", 55.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 3, "4-Series 4K UHD smart TV", "Amazon Fire TV 43", 250.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CategoryID", "Description", "Name", "Price" },
                values: new object[] { 3, "Class LED 4K UHD Smart Fire TV (PN43951-22U, 2021 Model)", "Pioneer 43-inch", 210.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CategoryID", "Description", "InStock", "Name", "Price" },
                values: new object[] { 4, "Apple Flagship mobile phone with 256GB", false, "iPhone 13 Pro Max", 1200.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CategoryID", "Description", "Name", "Price", "URL" },
                values: new object[] { 4, "Samsung Flagship mobile phone with 256GB", "Samsung Galaxy S22 Ultra", 1000.0, "https://shop.samsung.com/ie/images/products/28636/21040/2000x2000/SM-S908BZKDEUB.webp" });
        }
    }
}
