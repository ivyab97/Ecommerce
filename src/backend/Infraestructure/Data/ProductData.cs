using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data
{
    public static class ProductData
    {
        public static void SeedData(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Samsung Smart TV 55 pulgadas",
                        Description = "Descubre un mundo de entretenimiento en alta definición con este televisor LED de 55 pulgadas. Su impresionante resolución 4K y la tecnología HDR te sumergen en imágenes vívidas y detalladas, creando una experiencia visual cautivadora que redefine tu forma de ver televisión. Disfruta de colores vibrantes, contrastes intensos y una claridad excepcional en cada escena, haciendo que cada momento cobre vida con una nitidez asombrosa. Con este televisor, cada película, serie o evento deportivo se convierte en una experiencia inmersiva que te transporta directamente al corazón de la acción."
,
                        Price = 735000,
                        Category = 2,
                        Discount = 20,
                        ImageUrl = "https://images.samsung.com/is/image/samsung/es-uhd-ku6000-ue55ku6000kxxc-008-side-black?$L2-Thumbnail$"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Aspiradora Dyson V11",
                        Description = "Disfruta de una limpieza sin complicaciones con esta aspiradora sin bolsa. Equipada con tecnología ciclónica de vanguardia y un filtro HEPA, atrapa eficazmente el polvo y los alérgenos, asegurando un ambiente más saludable en tu hogar. Su diseño sin bolsa te proporciona comodidad adicional, mientras que su potente succión deja tus suelos impecables en cada pasada. Simplifica tu rutina de limpieza con este dispositivo eficiente y de alto rendimiento.",
                        Price = 300000,
                        Category = 1,
                        ImageUrl = "https://i1.wp.com/webadictos.com/media/2020/06/dyson-v11-outsize-aspiradora_2.jpg?fit=1800%2C1800&ssl=1"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Dell XPS 13",
                        Description = "Este portátil ligero ofrece una experiencia excepcional con su pantalla táctil de 14 pulgadas. Con 8 GB de RAM, disfruta de un rendimiento fluido y ágil para todas tus tareas diarias. Su diseño compacto y potente lo convierte en el compañero perfecto para la productividad y el entretenimiento sobre la marcha. Conéctate, crea y disfruta con total libertad.",
                        Price = 2500000,
                        Category = 2,
                        Discount = 15,
                        ImageUrl = "https://th.bing.com/th/id/R.d2384bda8fccd883f9f8cf43a30413e7?rik=K9kvE0qdfX%2bq3Q&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Camiseta Adidas Originals",
                        Description = "Esta camiseta de algodón de manga corta es una elección perfecta para tu estilo casual. Con un estampado de logo que añade un toque de personalidad, te brinda comodidad y frescura durante todo el día. Ya sea para una salida informal o para relajarte en casa, esta camiseta se convertirá en un básico imprescindible en tu armario.",
                        Price = 20000,
                        Category = 3,
                        ImageUrl = "https://59314.cdn.lojaquevende.com.br/static/59314/sku/masculino-camiseta-camiseta-adidas-originals-logo-rosa--p-1594925891821.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Almohada Viscoelástica",
                        Description = "Disfruta de un descanso óptimo con esta almohada de espuma viscoelástica. Su funda de bambú ofrece suavidad y frescura, mientras que la espuma viscoelástica se adapta a la forma de tu cabeza y cuello para un soporte personalizado. Experimenta un sueño reparador y despierta renovado cada mañana.",
                        Price = 20000,
                        Category = 4,
                        Discount = 10,
                        ImageUrl = "https://promart.vteximg.com.br/arquivos/ids/749561-1000-1000/image-1f6900df483d4c149f335f189d35f8ab.jpg?v=637490110244330000"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Smartwatch Garmin Forerunner 245",
                        Description = "Este reloj inteligente es tu compañero perfecto para el fitness. Con monitor de ritmo cardíaco y GPS integrado, te ayuda a optimizar tu entrenamiento y a rastrear tus actividades con precisión. Además, su diseño elegante y funcional lo convierte en un accesorio imprescindible para tu estilo de vida activo.",
                        Price = 350000,
                        Category = 6,
                        ImageUrl = "https://powermetercity.com/wp-content/uploads/2019/05/Garmin-Forerunner-245-GPS-Running-Smartwatch-Slate-Gray-3.png"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Bicicleta GT Aggresso",
                        Description = "Bicicleta de montaña con cuadro de aluminio y suspensión delantera, ideal para aventuras off-road. Su construcción resistente y ligera ofrece un rendimiento óptimo en terrenos accidentados, mientras que la suspensión delantera absorbe los impactos para una conducción suave y controlada. ¡Explora nuevos caminos con confianza y comodidad!",
                        Price = 400000,
                        Category = 6,
                        Discount = 5,
                        ImageUrl = "https://content.bikeroar.com/system/product/000/100/748/large/GT-Bicycles_Aggressor-Disc-XS-26_white-red-blue-side_2015.jpg?1472295473"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "LEGO Classic Medium Box",
                        Description = "Este set de bloques de construcción para niños es una fuente infinita de creatividad. Con figuras y accesorios variados, inspira la imaginación y el juego interactivo. Construye mundos imaginarios y fomenta habilidades motoras y cognitivas mientras los más pequeños se divierten. ¡Un regalo perfecto para horas de diversión y aprendizaje!",
                        Price = 80000,
                        Category = 7,
                        ImageUrl = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6252/6252643ld.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Cerveza Artesanal IPA",
                        Description = "Cerveza artesanal IPA de 330 ml, pack de 6 unidades. Disfruta del sabor único y la frescura de esta cerveza de calidad premium. Con un equilibrio perfecto entre lúpulos aromáticos y maltas, cada sorbo es una experiencia para los amantes de la cerveza. Ideal para compartir con amigos o para disfrutar en cualquier ocasión.",
                        Price = 6000,
                        Category = 8,
                        ImageUrl = "https://th.bing.com/th/id/OIP.zOU4uKEJEthoqpsCgNd5PQHaLC?w=725&h=1080&rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de Herramientas Black+Decker",
                        Description = "Este completo set de herramientas de mano es imprescindible para reparaciones domésticas. Con una variedad de herramientas de alta calidad, desde destornilladores hasta llaves ajustables, estarás listo para abordar cualquier proyecto. Robustas, duraderas y organizadas en un práctico estuche, hacen que las tareas de bricolaje sean más fáciles y satisfactorias.",
                        Price = 79999,
                        Category = 10,
                        ImageUrl = "https://fravega.vteximg.com.br/arquivos/ids/312150-1000-1000/Set-de-herramientas-manuales-Black--Decker-HDT51-910.jpg?v=636392310833070000"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Vestido de Fiesta Elegante",
                        Description = "Deslumbra en cualquier ocasión con este elegante vestido de fiesta. Con un favorecedor escote en V y un delicado detalle de encaje, es perfecto para destacar tu estilo y elegancia. Su diseño atemporal y sofisticado lo convierte en una elección ideal para eventos especiales. ¡Brilla con confianza y glamour en cada paso!",
                        Price = 35000,
                        Category = 3,
                        Discount = 10,
                        ImageUrl = "https://cdn0.matrimonio.com.co/articles/images/dress/1/0/6/6/t30_m186601.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Silla Ergonómica de Oficina",
                        Description = "Silla de escritorio ergonómica con respaldo ajustable y ruedas para una comodidad óptima. Diseñada para brindar apoyo lumbar y mantener una postura adecuada durante largas sesiones de trabajo. Sus ruedas permiten una movilidad sin esfuerzo, mientras que su estilo moderno y funcional la convierte en el complemento perfecto para tu espacio de trabajo.",
                        Price = 149999,
                        Category = 4,
                        ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_855874-MLM28199817916_092018-F.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Crema Hidratante Facial Neutrogena",
                        Description = "Protege y nutre tu piel con esta crema hidratante facial de día con SPF 30. Formulada para todo tipo de piel, ofrece una hidratación intensa y una protección eficaz contra los daños causados por los rayos UV. Su fórmula ligera y no grasa la hace perfecta para usar bajo el maquillaje, proporcionando una piel suave, radiante y protegida durante todo el día.",
                        Price = 8000,
                        Category = 5,
                        ImageUrl = "https://plazavea.vteximg.com.br/arquivos/ids/234854-1000-1000/20125136.jpg?v=637030655810000000"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Raqueta de Tenis Wilson Pro Staff",
                        Description = "Potencia tu juego con esta raqueta de tenis de carbono. Equipada con tecnología de absorción de impactos, ofrece una sensación suave y controlada en cada golpe. Su diseño ligero y aerodinámico te permite deslizarte por la pista con facilidad, mientras que la construcción de carbono proporciona una combinación perfecta de potencia y precisión. Domina la cancha con estilo y confianza.",
                        Price = 180000,
                        Category = 6,
                        Discount = 15,
                        ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_2X_794390-MLM43617620753_092020-F.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Sartenes Cerámica T-fal",
                        Description = "Prepara tus comidas con facilidad con este juego de sartenes de cerámica antiadherente. Incluye 3 tamaños diferentes para adaptarse a tus necesidades culinarias. La superficie antiadherente garantiza una cocción sin problemas y una fácil limpieza. Con un diseño resistente y duradero, son ideales para cocinar de manera saludable y sabrosa en cualquier cocina.",
                        Price = 110999,
                        Category = 4,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/61cpkKCW2zL._AC_SX569_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Lámpara de Pie LED",
                        Description = "Lámpara de pie LED con regulador de intensidad y diseño moderno. Ilumina tu espacio con estilo y funcionalidad gracias a su tecnología LED de bajo consumo y su regulador de intensidad. Su diseño moderno complementa cualquier decoración, mientras que su luz ajustable crea el ambiente perfecto para cada ocasión. Añade un toque de elegancia y practicidad a tu hogar.",
                        Price = 16999,
                        Category = 4,
                        ImageUrl = "https://lw-cdn.com/images/A8D7BA23AD52/k_6d8b4629109401923e80ac17b79198d2;w_1600;h_1600;q_100/lampara-de-pie-led-oficina-somidia-dimmer-blanco.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Cámara de Acción GoPro HERO9",
                        Description = "Cámara de acción resistente al agua con grabación en 4K, completa con accesorios. Captura tus aventuras en alta definición y sin preocupaciones gracias a su resistencia al agua. Con calidad de imagen excepcional y una variedad de accesorios incluidos, como soportes y correas, estarás listo para cualquier desafío. Registra cada momento emocionante con claridad y detalle asombrosos.",
                        Price = 822999,
                        Category = 2,
                        ImageUrl = "https://netpc.uy/wp-content/uploads/2021/03/1-219-1024x1024.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Gafas de Sol Ray-Ban",
                        Description = "Gafas de sol polarizadas con montura de acetato y lentes UV400. Protege tus ojos con estilo y confort gracias a su diseño polarizado que reduce los reflejos y la fatiga visual. La montura de acetato ofrece durabilidad y elegancia, mientras que las lentes UV400 bloquean los dañinos rayos UV. Disfruta de una visión clara y nítida mientras te proteges del sol con estas gafas de calidad.",
                        Price = 52999,
                        Category = 3,
                        Discount = 10,
                        ImageUrl = "https://i5.walmartimages.com/asr/eaf39d77-26b2-4e40-a8a8-26f2d30869ad.9423bef8ef7337b1d8c576fb2513164e.jpeg?odnWidth=1000&odnHeight=1000&odnBg=ffffff"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Cama Individual de Madera",
                        Description = "Cama individual con estructura de madera maciza y cabecero acolchado. Añade estilo y comodidad a tu dormitorio con esta cama de calidad. La robusta estructura de madera maciza garantiza durabilidad y estabilidad, mientras que el cabecero acolchado brinda un toque de elegancia y confort. Crea un ambiente acogedor y relajante para tus noches de descanso.",
                        Price = 58600,
                        Category = 4,
                        ImageUrl = "https://vuanem.com/blog/wp-content/uploads/2022/06/mau-giuong-go-chan-cao2.png"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Acondicionador Capilar Hidratante",
                        Description = "Acondicionador capilar hidratante para cabello seco y dañado, envase de 500 ml. Revitaliza y restaura la salud de tu cabello con este acondicionador formulado específicamente para cabello seco y dañado. Su fórmula hidratante nutre profundamente cada hebra, dejando el cabello suave, sedoso y manejable. Convierte el cuidado del cabello en un placer diario y luce un cabello radiante y saludable.",
                        Price = 8999,
                        Category = 5,
                        ImageUrl = "https://res.cloudinary.com/walmart-labs/image/upload/w_960,dpr_auto,f_auto,q_auto:best/gr/images/product-images/img_large/00750630622031L.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Jeans Levi\'s 501",
                        Description = "Pantalones vaqueros de corte recto y lavado oscuro, tallas disponibles: 28 .Estilo clásico y versátil para tu guardarropa.Confeccionados con denim de alta calidad, estos pantalones ofrecen comodidad y durabilidad.El corte recto proporciona un ajuste favorecedor, mientras que el lavado oscuro añade un toque de sofisticación.Completa tu look con estos pantalones que combinan con cualquier ocasión.",
                        Price = 29000,
                        Category = 3,
                        Discount = 20,
                        ImageUrl = "https://th.bing.com/th/id/OIP.IAnlOIP1QdYyXurUpvfjgAHaJ3?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Mochila de Senderismo Quechua",
                        Description = "Mochila de senderismo con capacidad de 40 litros y sistema de ventilación. Prepárate para tus aventuras al aire libre con esta mochila espaciosa y funcional. Su diseño ergonómico y sistema de ventilación mantienen tu espalda fresca y cómoda durante largas caminatas. Con múltiples compartimentos y correas ajustables, te ofrece organización y comodidad para llevar todo lo necesario. ¡Explora la naturaleza con estilo y confort!",
                        Price = 130000,
                        Category = 6,
                        ImageUrl = "https://th.bing.com/th/id/R.4eabdbb111407617031f2905e992ae2a?rik=hrWxgNU%2f6uUHBQ&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Vino Tinto Reserva Marqués de Cáceres",
                        Description = "Botella de vino tinto reserva, añada 2017, Denominación de Origen Rioja. Disfruta de la excelencia enológica con este vino tinto reserva cuidadosamente elaborado. Con una añada excepcional, ofrece aromas complejos y sabores intensos que deleitarán tu paladar. Proveniente de la prestigiosa región de Rioja, garantiza calidad y tradición en cada sorbo. Eleva tus momentos especiales con este vino de distinción.",
                        Price = 35999,
                        Category = 8,
                        ImageUrl = "https://th.bing.com/th/id/OIP.AUrvOxdlC6KV6wTmbIk0qgHaOj?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Monitor Acer Full HD 24",
                        Description = "Monitor de computadora LED de 24 pulgadas con resolución Full HD. Experimenta imágenes claras y nítidas en una pantalla de gran tamaño. Perfecto para trabajar, jugar o ver películas, este monitor ofrece una calidad de visualización excepcional. Con tecnología LED, garantiza colores vibrantes y un bajo consumo de energía. Mejora tu experiencia informática con este monitor de alto rendimiento.",
                        Price = 443995,
                        Category = 2,
                        Discount = 10,
                        ImageUrl = "https://c1.neweggimages.com/ProductImageCompressAll1280/24-009-642-02.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Plancha de Vapor Philips",
                        Description = "Plancha de vapor con suela de cerámica y función de autoapagado. Simplifica tus tareas de planchado con esta plancha de alta calidad. La suela de cerámica asegura un deslizamiento suave sobre cualquier tejido, mientras que la función de autoapagado proporciona seguridad y tranquilidad. Con un diseño ergonómico y eficiente, logra resultados impecables en menos tiempo. Haz que el planchado sea más fácil y efectivo con esta plancha innovadora.",
                        Price = 114251,
                        Category = 4,
                        ImageUrl = "https://images.philips.com/is/image/PhilipsConsumer/GC5036_20-IMS-es_ES?$jpglarge$&wid=1250"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Maletín de Cuero para Portátil",
                        Description = "Maletín ejecutivo de cuero genuino con compartimento acolchado para portátil. Lleva tu estilo y tus dispositivos con elegancia y seguridad. El cuero genuino proporciona durabilidad y un aspecto profesional, mientras que el compartimento acolchado protege tu portátil de golpes y arañazos. Con múltiples bolsillos y un diseño práctico, este maletín es ideal para profesionales en movimiento que valoran la calidad y el estilo.",
                        Price = 98043,
                        Category = 10,
                        Discount = 15,
                        ImageUrl = "https://www.losroblespolotime.com/wp-content/uploads/2018/02/maletines-de-cuero-hombre-ejecutivos1206r-1080x1080.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Toallas de Baño comunes",
                        Description = "Juego de toallas de baño de algodón, incluye 2 toallas de mano y 2 de baño. Dale un toque de lujo a tu baño con este juego de toallas suaves y absorbentes. Fabricadas con algodón de alta calidad, ofrecen una sensación de confort y frescura después de cada ducha. Con un diseño elegante y duradero, son el complemento perfecto para tu rutina de cuidado personal. Disfruta de la máxima comodidad y estilo en tu hogar.",
                        Price = 23999,
                        Category = 4,
                        ImageUrl = "https://www.sedalinne.com/blog/wp-content/uploads/2016/06/CATALOGO-ENERO-2016-BAJA-42-1024x1024.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Secador de Pelo Remington Ionic",
                        Description = "Secador de pelo iónico con difusor y concentrador de aire. Obtén resultados profesionales desde la comodidad de tu hogar con este secador de pelo avanzado. La tecnología iónica reduce el frizz y mejora la suavidad y brillo de tu cabello. El difusor es ideal para cabello rizado o con ondas, mientras que el concentrador de aire permite un secado preciso. Dale a tu cabello el cuidado que se merece con este secador de alto rendimiento.",
                        Price = 58831,
                        Category = 5,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/61zQL-2rpzL._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Silla de Playa Plegable",
                        Description = "Silla plegable de playa con respaldo reclinable y reposabrazos. Disfruta del máximo confort en la playa con esta silla versátil. Su diseño plegable la hace fácil de transportar y almacenar, mientras que el respaldo reclinable y los reposabrazos ofrecen una posición personalizada para relajarte. Construida con materiales resistentes, es perfecta para largas jornadas bajo el sol. Prepárate para tus días de playa con estilo y comodidad.",
                        Price = 42530,
                        Category = 6,
                        Discount = 10,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/71pw6mc4GFL._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Auriculares Sony WH-1000XM4",
                        Description = "Auriculares inalámbricos Bluetooth con cancelación de ruido activa. Sumérgete en tu música favorita con estos auriculares que ofrecen una experiencia auditiva excepcional. La tecnología Bluetooth te permite una conexión sin cables, mientras que la cancelación de ruido activa bloquea el ruido exterior para una inmersión total. Con un diseño ergonómico y controles intuitivos, disfruta de la libertad y la calidad de sonido en cualquier lugar.",
                        Price = 89999,
                        Category = 2,
                        ImageUrl = "https://www.bhphotovideo.com/images/images2500x2500/sony_wh1000xm4_b_wh_1000xm4_wireless_noise_canceling_over_ear_1582549.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Crema Corporal Hidratante Lavanda",
                        Description = "Crema corporal hidratante con aroma de lavanda, envase de 250 ml. Nutre y suaviza tu piel con esta crema delicadamente perfumada. La lavanda ofrece propiedades relajantes y calmantes, mientras que la fórmula hidratante deja tu piel suave y tersa. Ideal para mimarte después de un largo día, esta crema te envuelve en un aroma reconfortante y te ayuda a relajarte. Disfruta de una piel radiante y perfumada con esta crema de calidad.",
                        Price = 7950,
                        Category = 5,
                        ImageUrl = "https://mundoverde.com.pe/wp-content/uploads/2021/09/IMG_5203.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Funda Nórdica Algodón Percal",
                        Description = "Funda nórdica de algodón percal, tamaño queen, incluye fundas de almohada. Renueva tu dormitorio con esta funda nórdica de calidad premium. Fabricada con algodón percal, ofrece suavidad y frescura para un descanso reparador. El tamaño queen proporciona una cobertura generosa, mientras que las fundas de almohada a juego completan el conjunto. Dale un toque de estilo y confort a tu cama con esta funda nórdica elegante y funcional.",
                        Price = 7550,
                        Category = 4,
                        ImageUrl = "https://th.bing.com/th/id/R.20eeebe126d017ce8fa1c815dbaf35eb?rik=mqliLGuUG0eP7Q&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Teclado Mecánico Corsair K95 RGB",
                        Description = "Teclado mecánico para juegos con retroiluminación RGB y switches Cherry MX Red. Domina tus juegos con este teclado diseñado para ofrecer un rendimiento excepcional. Los switches Cherry MX Red proporcionan una pulsación suave y lineal, perfecta para una respuesta rápida en tus partidas. La retroiluminación RGB te permite personalizar la iluminación según tu estilo y preferencias. Con este teclado, disfruta de una experiencia de juego inigualable y haz que cada movimiento cuente.",
                        Price = 319919,
                        Category = 2,
                        ImageUrl = "https://c1.neweggimages.com/ProductImageCompressAll1280/23-816-135-V03.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Cuchillos de Cocina",
                        Description = "Set de cuchillos de cocina de acero inoxidable, incluye 5 piezas. Equipa tu cocina con este versátil set de cuchillos diseñado para todas tus necesidades culinarias. Fabricados con acero inoxidable de alta calidad, estos cuchillos ofrecen durabilidad y precisión en cada corte. Con una variedad de tamaños y estilos, desde el cuchillo de chef hasta el cuchillo para pan, estarás preparado para cualquier tarea en la cocina. Simplifica tu preparación de alimentos y eleva tu experiencia culinaria con este set de cuchillos imprescindible.",
                        Price = 48999,
                        Category = 4,
                        Discount = 10,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/71P0lGwQ%2BSL._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Aspiradora Robot Roomba",
                        Description = "Aspiradora robot inteligente con mapeo de habitaciones y control por voz. Simplifica la limpieza de tu hogar con esta aspiradora robot de última generación. Su capacidad de mapeo de habitaciones te permite programarla para limpiar áreas específicas, mientras que el control por voz ofrece comodidad y facilidad de uso. Con sensores avanzados, evita obstáculos y limpia de manera eficiente. Disfruta de un hogar limpio y ordenado con esta aspiradora inteligente.",
                        Price = 499999,
                        Category = 1,
                        Discount = 5,
                        ImageUrl = "https://ojeando.es/wp-content/uploads/2020/06/irobot-roomba-e5.jpg"

                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Laptop Dell XPS 15",
                        Description = "Laptop ultradelgada con pantalla OLED de 15.6 pulgadas y procesador Intel Core i7. Experimenta la potencia y la elegancia en un solo dispositivo con esta laptop ultradelgada. La pantalla OLED ofrece colores vibrantes y negros profundos, mientras que el procesador Intel Core i7 garantiza un rendimiento excepcional. Con un diseño elegante y ligero, es ideal para trabajar o disfrutar de contenido multimedia en cualquier lugar. Hazte con esta laptop y lleva tu productividad a un nuevo nivel.",
                        Price = 230000,
                        Category = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.ae6ed7bc1d14a535b8f210b80a24366a?rik=4jze262VE41JUg&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Bolso de Cuero Genuino",
                        Description = "Bolso de mano elegante hecho de cuero genuino con diseño clásico. Añade un toque de sofisticación a tu estilo con este bolso de mano de alta calidad. Fabricado con cuero genuino, ofrece durabilidad y estilo atemporal. Su diseño clásico complementa cualquier outfit, ya sea casual o formal. Con espacio suficiente para tus esenciales diarios, es perfecto para el trabajo, las citas o las ocasiones especiales. Haz una declaración de elegancia con este bolso de mano exclusivo.",
                        Price = 90000,
                        Category = 3,
                        ImageUrl = "https://www.cuiroma.com/1610-large_default/bolso-de-cuero-genuino.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Toallas de Baño",
                        Description = "Set de toallas de baño de algodón suave, incluye 6 piezas en varios colores. Renueva tu baño con este completo set de toallas que combina comodidad y estilo. Fabricadas con algodón suave y absorbente, estas toallas son perfectas para envolverte en lujo después de cada ducha. Con seis piezas en una variedad de colores, puedes coordinarlas fácilmente con la decoración de tu baño. Disfruta de la frescura y la suavidad en cada uso con este set de toallas de calidad.",
                        Price = 31999,
                        Category = 4,
                        ImageUrl = "https://th.bing.com/th/id/OIP.UBiyo398JdTaO3EmEKSuZQHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Secadora de Ropa LG",
                        Description = "Secadora de ropa con capacidad de 7.4 pies cúbicos y tecnología de secado rápido. Simplifica tu rutina de lavandería con esta secadora de alta capacidad. Su tecnología de secado rápido te permite tener tu ropa lista en menos tiempo, ahorrando energía y tiempo. Con una capacidad de 7.4 pies cúbicos, es ideal para familias numerosas. Mantén tu ropa fresca y lista para usar con esta secadora eficiente y de alto rendimiento.",
                        Price = 999999,
                        Category = 1,
                        Discount = 15,
                        ImageUrl = "https://crecos.vteximg.com.br/arquivos/ids/182675-1000-1000/Lavadora-Secadora-Electrica-LG-WD11VVC3S6C-10-5-y-7-Kg-Carga-Frontal-DirectDrive-Inverter-Color-Acero_4.jpg?v=637291339645400000"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Smartphone Samsung Galaxy S22",
                        Description = "Smartphone con pantalla AMOLED de 6.6 pulgadas, cámara de 108 MP y 5G. Experimenta la potencia y la innovación en la palma de tu mano con este smartphone de última generación. La pantalla AMOLED ofrece colores vibrantes y detalles nítidos, mientras que la cámara de 108 MP captura imágenes increíbles con claridad y precisión. Con conectividad 5G, disfruta de velocidades ultrarrápidas para navegar, transmitir y jugar sin problemas. Descubre un nuevo nivel de rendimiento y tecnología con este smartphone avanzado.",
                        Price = 970423,
                        Category = 2,
                        ImageUrl = "https://www.whatsmobiles.com/wp-content/uploads/2022/01/samsung-galaxy-s22-ultra.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de Maquillaje Profesional",
                        Description = "Kit completo de maquillaje profesional con sombras de ojos, labiales y brochas. Transforma tu look con este kit de maquillaje que incluye todo lo que necesitas para crear looks impresionantes. Las sombras de ojos en una variedad de tonos te permiten experimentar con diferentes estilos, mientras que los labiales añaden un toque de color y glamour. Las brochas de alta calidad facilitan la aplicación precisa y mezcla de los productos. Eleva tu juego de maquillaje con este kit completo y versátil.",
                        Price = 49999,
                        Category = 5,
                        ImageUrl = "https://m.media-amazon.com/images/I/71wo93nsVEL._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Balón de Fútbol Adidas",
                        Description = "Balón de fútbol oficial de la FIFA, diseñado para un rendimiento óptimo. Juega como los profesionales con este balón de alta calidad. Diseñado y probado según los estándares de la FIFA, ofrece un rendimiento excepcional en el campo. Con un diseño aerodinámico y duradero, te proporciona precisión y control en cada golpe. Domina el juego con este balón que cumple con las exigencias de los mejores torneos del mundo.",
                        Price = 29999,
                        Category = 6,
                        ImageUrl = "https://i.pinimg.com/originals/dc/8c/d2/dc8cd20e204181feda97133eaef73b7c.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Construcción LEGO Star Wars",
                        Description = "Set de construcción LEGO Star Wars con figuras de personajes y naves espaciales. Embárcate en épicas aventuras galácticas con este set de construcción que combina la emoción de Star Wars con la creatividad de LEGO. Incluye figuras de tus personajes favoritos y detalladas naves espaciales para recrear escenas memorables de la saga. Con instrucciones paso a paso, te sumergirás en el universo Star Wars mientras construyes y juegas. ¡Que la Fuerza esté contigo mientras exploras este emocionante set LEGO!",
                        Price = 89999,
                        Category = 7,
                        ImageUrl = "https://th.bing.com/th/id/R.c445de809477f17f095b1adc755913ad?rik=2kszFgqC9w9Byw&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Libro Bestseller: 'El Alquimista' de Paulo Coelho",
                        Description = "Novela de Paulo Coelho que narra la búsqueda de un joven por su destino y la realización personal. Sumérgete en este cautivador relato que sigue el viaje de autodescubrimiento de un protagonista en busca de su propósito en la vida. A través de encuentros inspiradores y desafíos emocionantes, la historia te lleva en un viaje transformador lleno de enseñanzas profundas y reflexiones sobre el destino y la libertad. Una lectura que te invita a reflexionar sobre tu propio camino hacia la realización personal.",
                        Price = 18200,
                        Category = 9,
                        ImageUrl = "https://th.bing.com/th/id/OIP.sL5SnA4DPVj2aAJ0TRa05wHaLH?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de Herramientas de Bricolaje",
                        Description = "Kit de herramientas completo para proyectos de bricolaje en casa, incluye martillo, destornilladores, etc. Equipa tu hogar con este completo conjunto de herramientas que te ayuda a abordar una amplia variedad de proyectos de bricolaje. Con un martillo resistente, destornilladores de varios tamaños, llaves ajustables y más, tienes todo lo necesario para reparaciones, montaje de muebles y otros trabajos en casa. Simplifica tus tareas de mantenimiento con este práctico y versátil kit de herramientas.",
                        Price = 79899,
                        Category = 10,
                        ImageUrl = "https://th.bing.com/th/id/R.c1ff43ceb1f9ecbfc022cee8446fdb87?rik=nt0dMENPO0E50g&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Cafetera Espresso De'Longhi",
                        Description = "Cafetera espresso automática con sistema de espuma de leche y selección de intensidad. Disfruta del café perfecto en casa con esta cafetera que combina conveniencia y calidad. El sistema de espuma de leche te permite crear capuchinos y lattes cremosos, mientras que la selección de intensidad te permite personalizar tu bebida según tus preferencias. Con un diseño elegante y fácil de usar, es ideal para los amantes del café que buscan comodidad y sabor excepcionales.",
                        Price = 233988,
                        Category = 1,
                        ImageUrl = "https://th.bing.com/th/id/OIP.A6cDZMQZT-3N_VGtAchTBAHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Smartwatch Apple Watch Series 7",
                        Description = "Smartwatch con pantalla Retina siempre activa y seguimiento avanzado de la salud. Mantén un estilo de vida activo y saludable con este smartwatch que ofrece lo último en tecnología y funcionalidad. Su pantalla Retina siempre activa te permite ver la hora y tus datos de salud de un vistazo, mientras que el seguimiento avanzado de la salud monitoriza tus actividades físicas, frecuencia cardíaca y más. Con notificaciones en tiempo real y una amplia gama de aplicaciones, es tu compañero perfecto para alcanzar tus objetivos de bienestar.",
                        Price = 394994,
                        Category = 2,
                        ImageUrl = "https://th.bing.com/th/id/R.a7387a7dc217cdeb0af458095dce22f8?rik=WU6fcZ7espeomA&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Caja de Vinos Varietales",
                        Description = "Caja de vinos varietales seleccionados, incluye 6 botellas de diferentes cepas. Descubre una selección excepcional de vinos que deleitarán tu paladar con esta caja cuidadosamente elegida. Con seis botellas de diferentes cepas, desde tintos robustos hasta blancos refrescantes, esta colección ofrece una experiencia de degustación diversa y emocionante. Perfecta para disfrutar en reuniones sociales o para regalar a los amantes del vino, esta caja es una elección elegante y sofisticada.",
                        Price = 34500,
                        Category = 8,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81Wsb4Blr%2BL._AC_SY741_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Zapatillas Deportivas Nike Air Zoom Pegasus",
                        Description = "Zapatillas deportivas con amortiguación reactiva y suela de tracción para correr cómodamente. Alcanza tus metas de entrenamiento con estas zapatillas diseñadas para brindarte comodidad y rendimiento. La amortiguación reactiva absorbe el impacto de cada paso, mientras que la suela de tracción proporciona agarre y estabilidad en una variedad de superficies. Ya sea en el gimnasio o en la pista, estas zapatillas te permiten correr con confianza y comodidad.",
                        Price = 120911,
                        Category = 6,
                        ImageUrl = "https://th.bing.com/th/id/R.59588929ca4c74f1d2b80c4444c86b8a?rik=%2bKysx8%2bM2A%2fGPA&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Bloques de Construcción Magnéticos",
                        Description = "Set de bloques de construcción magnéticos para niños, fomenta la creatividad y la habilidad motora. Despierta la imaginación de tus hijos con este set de bloques magnéticos que les permite crear estructuras infinitas. La combinación de colores vibrantes y piezas magnéticas ofrece oportunidades ilimitadas para construir y experimentar. Además de divertirse, los niños desarrollan habilidades motoras finas y aprenden conceptos de ciencia y geometría de manera intuitiva. ¡Explora el mundo de la construcción de manera creativa y educativa con este emocionante set de bloques magnéticos!",
                        Price = 45999,
                        Category = 7,
                        ImageUrl = "https://th.bing.com/th/id/OIP.P61m2Pr3M_iWDUunq2wJgwHaHT?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Caja de Chocolates Gourmet",
                        Description = "Caja de chocolates gourmet de alta calidad, ideal para regalar o disfrutar en ocasiones especiales. Deléitate con esta exquisita selección de chocolates elaborados con los mejores ingredientes. Cada bocado es una experiencia indulgente que deleitará tus sentidos. Presentada en una elegante caja, es el regalo perfecto para cualquier ocasión especial o simplemente para darte un capricho. Disfruta de momentos dulces y memorables con esta caja de chocolates gourmet.",
                        Price = 49779,
                        Category = 8,
                        ImageUrl = "https://i5.walmartimages.com/asr/007378ed-c963-4fd9-b5d8-733722f4608f.1f45d6c682c9254f0f15baa1d88c9212.jpeg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Pinceles y Lienzos para Pintura",
                        Description = "Set de pinceles de diferentes tamaños y lienzos para pintura, perfecto para artistas aficionados y profesionales. Exprésate a través del arte con este completo set que ofrece todo lo necesario para dejar volar tu creatividad. Los pinceles de varios tamaños te permiten trabajar con precisión y detalle, mientras que los lienzos de calidad ofrecen una superficie perfecta para tus creaciones. Ya seas un principiante entusiasta o un artista experimentado, este set es tu compañero ideal en el mundo de la pintura.",
                        Price = 33939,
                        Category = 9,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/A1GwBEDZgFL._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Herramientas de Jardinería",
                        Description = "Set completo de herramientas de jardinería, incluye pala, rastrillo, tijeras de podar, etc. Equípate para tus proyectos al aire libre con este conjunto de herramientas diseñado para jardineros de todos los niveles. Con una pala resistente, un rastrillo para limpiar y nivelar, tijeras de podar para dar forma a tus plantas y más, tienes todo lo necesario para cuidar y embellecer tu jardín. Simplifica tu trabajo en el jardín y disfruta de un espacio verde exuberante con este completo set de herramientas.",
                        Price = 39979,
                        Category = 10,
                        ImageUrl = "https://m.media-amazon.com/images/I/611BfOCXEeL._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Butaca de Oficina Ergonómica ",
                        Description = "Silla de oficina ergonómica con soporte lumbar ajustable y reposabrazos acolchados. Prioriza tu comodidad y salud en el trabajo con esta silla diseñada para ofrecer el máximo confort. El soporte lumbar ajustable se adapta a tu espalda para una postura óptima, mientras que los reposabrazos acolchados brindan apoyo y alivio durante largas horas de trabajo. Con un diseño ergonómico y materiales de alta calidad, esta silla mejora tu bienestar y productividad en el entorno laboral.",
                        Price = 189999,
                        Category = 4,
                        ImageUrl = "https://m.media-amazon.com/images/I/71yUHcOanKL._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de Cuidado de la Piel",
                        Description = "Kit completo de cuidado de la piel que incluye limpiador facial, tónico, crema hidratante, etc. Transforma tu rutina de cuidado facial con este completo kit diseñado para nutrir y rejuvenecer tu piel. El limpiador facial elimina suavemente las impurezas, el tónico equilibra y refresca, mientras que la crema hidratante proporciona una hidratación profunda y duradera. Con otros productos esenciales incluidos, este kit ofrece todo lo necesario para una piel radiante y saludable en cada paso.",
                        Price = 49899,
                        Category = 5,
                        ImageUrl = "https://th.bing.com/th/id/R.82e5011d4e83c3daa6edd05b048f7540?rik=5pykmWYyLs%2fYTg&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Juego de Mesa 'Catan'",
                        Description = "Juego de mesa estratégico que te transporta a la era de los descubrimientos, ideal para reuniones familiares y de amigos. Vive la emoción de la exploración y el comercio en este juego que recrea la fascinante era de los descubrimientos. Con desafíos estratégicos y decisiones importantes, cada partida ofrece una experiencia única llena de diversión y aprendizaje. Perfecto para compartir con familiares y amigos, este juego promueve la camaradería y la competencia saludable en cada encuentro.",
                        Price = 15000,
                        Category = 6,
                        ImageUrl = "https://mejoresjuegosdemesade.com/wp-content/uploads/2020/11/pic17996-scaled.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Batidora de Mano KitchenAid",
                        Description = "Batidora de mano con múltiples velocidades y accesorios intercambiables para preparar una variedad de recetas",
                        Price = 29899,
                        Category = 1,
                        ImageUrl = "https://th.bing.com/th/id/OIP.qITwgFqkKuINs7ghNPPAKgHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Auriculares Inalámbricos Sony WH-1000XM4",
                        Description = "Auriculares inalámbricos con cancelación de ruido adaptativa y calidad de sonido premium. Sumérgete en tu música con estos auriculares que ofrecen una experiencia auditiva excepcional. La cancelación de ruido adaptativa bloquea eficazmente los sonidos externos, permitiéndote disfrutar de tu música sin distracciones. Con una calidad de sonido premium, cada nota se reproduce con claridad y precisión, brindándote una experiencia de audio inigualable. Disfruta de la libertad inalámbrica y el rendimiento de audio superior con estos auriculares de alta gama.",
                        Price = 319999,
                        Category = 2,
                        ImageUrl = "https://plazavea.vteximg.com.br/arquivos/ids/648142-1000-1000/image-21437c9a137e44e1ae8aa15f27b82528.jpg?v=637448075451400000"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Bufanda de Lana Tejida a Mano",
                        Description = "Bufanda de lana suave y cálida tejida a mano, perfecta para los días fríos de invierno. Envuélvete en calidez y confort con esta bufanda cuidadosamente tejida a mano. Fabricada con lana de alta calidad, ofrece una suavidad excepcional y una sensación reconfortante alrededor del cuello. Su diseño tejido a mano le añade un toque de artesanía y estilo único. Ya sea para pasear al aire libre o para complementar tu atuendo, esta bufanda es el accesorio esencial para enfrentar los rigores del invierno con estilo.",
                        Price = 16999,
                        Category = 3,
                        ImageUrl = "https://th.bing.com/th/id/OIP.7Rnzy4JWNkkc5qeBu6KpJAHaO3?rs=1&pid=ImgDetMain"
                    },
                     new Product
                     {
                         ProductId = Guid.NewGuid(),
                         Name = "Set de Velas Aromáticas",
                         Description = "Set de velas aromáticas con fragancias naturales para crear un ambiente relajante en tu hogar. Transforma tu espacio en un oasis de serenidad con este encantador set de velas. Cada vela está cuidadosamente elaborada con fragancias naturales que llenan la habitación con aromas reconfortantes y relajantes. Ya sea para una noche tranquila en casa o para una sesión de meditación, este set te ayudará a crear el ambiente perfecto para relajarte y rejuvenecer cuerpo y mente.",
                         Price = 15955,
                         Category = 4,
                         ImageUrl = "https://velasarcanjo.com.br/wp-content/uploads/2022/01/PRF260-2.webp"
                     },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Cepillo Eléctrico Oral-B",
                        Description = "Cepillo de dientes eléctrico recargable con tecnología de detección de posición y temporizador. Optimiza tu rutina de higiene bucal con este cepillo avanzado que garantiza una limpieza efectiva. La tecnología de detección de posición te guía para asegurar una cobertura completa de tus dientes y encías, mientras que el temporizador te indica cuándo cambiar de área. Con cerdas de alta calidad y una batería recargable, es la elección ideal para una sonrisa saludable y radiante.",
                        Price = 35567,
                        Category = 5,
                        ImageUrl = "https://res.cloudinary.com/walmart-labs/image/upload/w_960,dpr_auto,f_auto,q_auto:best/gr/images/product-images/img_large/00421020182661L.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Pelota de Baloncesto Spalding NBA",
                        Description = "Pelota oficial de la NBA fabricada con materiales de alta calidad para un rendimiento óptimo. Vive la emoción del baloncesto con esta pelota oficial utilizada en los mejores torneos. Fabricada con materiales premium, ofrece un agarre excepcional y una respuesta precisa en cada dribbling, pase y tiro. Ya sea en la cancha o en tu patio trasero, esta pelota te permite disfrutar del juego con la autenticidad y calidad que esperas de la NBA.",
                        Price = 55794,
                        Category = 6,
                        ImageUrl = "https://th.bing.com/th/id/OIP.aSw6EBUAKtHSRi3w8ZVL2AHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Rompecabezas 3D de la Torre Eiffel",
                        Description = "Rompecabezas en 3D de la famosa Torre Eiffel, ideal para entusiastas de la arquitectura. Vive la experiencia de construir uno de los íconos arquitectónicos más reconocidos del mundo con este rompecabezas en 3D. Cada pieza de este desafío te acerca más a la majestuosidad de la Torre Eiffel, mientras ejercitas tu mente y desarrollas habilidades espaciales. Perfecto para entusiastas de la arquitectura y amantes de los rompecabezas, este set ofrece horas de diversión y satisfacción al completar esta obra maestra en miniatura.",
                        Price = 25655,
                        Category = 7,
                        ImageUrl = "https://www.toysbestideas.com/images/123586/BuilDream-3D-Puzzle-Eiffel-Tower-66-pieces-2.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Vino Tinto Reserva",
                        Description = "Botella de vino tinto reserva con cuerpo y sabor intensos, perfecto para ocasiones especiales. Celebra momentos memorables con esta exquisita botella de vino tinto reserva. Con su cuerpo robusto y sabor profundo, esta selección ofrece una experiencia sensorial única que deleitará a los aficionados del vino. Ya sea para una cena romántica, una celebración familiar o un regalo especial, esta botella añade un toque de elegancia y sofisticación a cualquier ocasión.",
                        Price = 30999,
                        Category = 8,
                        ImageUrl = "https://th.bing.com/th/id/OIP.IxKFqPXn8UebJyd8u-TBAgHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Cepillo Eléctrico Colgate",
                        Description = "Cepillo eléctrico recargable con tecnología de limpieza avanzada para una salud bucal óptima. Mejora tu rutina de cuidado bucal con este cepillo eléctrico que ofrece una limpieza superior. Con tecnología de limpieza avanzada, elimina más placa que un cepillo manual, manteniendo tus dientes y encías saludables. El diseño recargable y ergonómico lo hace fácil y cómodo de usar. Descubre una sonrisa más brillante y una boca más saludable con este cepillo eléctrico de calidad.",
                        Price = 25666,
                        Category = 5,
                        ImageUrl = "https://th.bing.com/th/id/OIP.FO98Jv9ZUgYGZupqbByo-gHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Bicicleta de Montaña",
                        Description = "Bicicleta de montaña con cuadro de aluminio y suspensión delantera, ideal para aventuras en terrenos accidentados. Conquista los senderos más desafiantes con esta bicicleta diseñada para el rendimiento y la durabilidad. El cuadro de aluminio garantiza ligereza y resistencia, mientras que la suspensión delantera absorbe los golpes en terrenos irregulares. Ya sea en montañas, bosques o caminos escarpados, esta bicicleta te ofrece control y comodidad para disfrutar al máximo de tus aventuras al aire libre.",
                        Price = 350444,
                        Category = 6,
                        ImageUrl = "https://th.bing.com/th/id/OIP.tp3k62QfNs3RC6VGbgMK9QHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Muñeca Barbie Fashionista",
                        Description = "Muñeca Barbie Fashionista con diversidad de estilos y looks para inspirar el juego creativo. ¡Desata tu creatividad y estilo con la muñeca Barbie Fashionista! Con una amplia gama de estilos y looks diversos, esta muñeca es el lienzo perfecto para crear historias y aventuras únicas. Desde atuendos elegantes hasta conjuntos deportivos, cada Barbie Fashionista refleja la diversidad y la moda del mundo real. ¡Explora tu imaginación y crea tus propias tendencias con Barbie!",
                        Price = 19999,
                        Category = 7,
                        ImageUrl = "https://i5.walmartimages.com/asr/a50d9058-03a5-4094-bf53-e6c4a860daab_1.a76618ad67f4cd87d4fd69421b627db4.jpeg?odnWidth=1000&odnHeight=1000&odnBg=ffffff"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Cerveza Artesanal Pack Variado",
                        Description = "Pack variado de cervezas artesanales seleccionadas de diferentes estilos y sabores. Descubre una experiencia única de degustación con este pack que ofrece una variedad de cervezas artesanales cuidadosamente seleccionadas. Desde ales robustas hasta lagers refrescantes, cada botella te lleva en un viaje de sabores y estilos. Perfecto para compartir con amigos o disfrutar en solitario, este pack es una invitación a explorar el mundo diverso y emocionante de la cerveza artesanal.",
                        Price = 10999,
                        Category = 8,
                        ImageUrl = "https://naciontequila.com/wp-content/uploads/2021/03/Six_Pack_Cerveza_Artesanal_Wendlandt.jpeg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Cuaderno de Notas de Cuero",
                        Description = "Cuaderno de notas de cuero genuino con papel de alta calidad, perfecto para tomar apuntes o dibujar. Eleva tu experiencia de escritura con este elegante cuaderno elaborado con cuero genuino y papel de primera calidad. Ya sea para anotar tus ideas, reflexiones o bocetos, cada página ofrece una superficie suave y resistente para plasmar tus pensamientos. Con un diseño duradero y sofisticado, es el compañero ideal para tu vida diaria, ya sea en el trabajo, la escuela o tus momentos creativos.",
                        Price = 15000,
                        Category = 9,
                        ImageUrl = "https://th.bing.com/th/id/R.293baa69fe461d6e8c3f6046a511e51e?rik=pCpCqu75TTSwJQ&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Taladro Inalámbrico Bosch",
                        Description = "Taladro inalámbrico con batería de larga duración y múltiples funciones para proyectos de bricolaje. Haz realidad tus proyectos con este taladro versátil que ofrece potencia y libertad de movimiento. Equipado con una batería de larga duración, te permite trabajar sin interrupciones durante más tiempo. Además, su diseño compacto y ergonómico facilita su manejo en espacios reducidos. Ya sea para perforar, atornillar o taladrar, este taladro inalámbrico es la herramienta perfecta para tus proyectos de bricolaje en casa o en el trabajo.",
                        Price = 198243,
                        Category = 10,
                        ImageUrl = "https://plazavea.vteximg.com.br/arquivos/ids/1512004-1000-1000/image-af25755c17524609b15a734685f3195f.jpg?v=637547892553400000"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Robot de Cocina Multifunción",
                        Description = "Robot de cocina multifunción con capacidad para cocinar una variedad de platos automáticamente. Simplifica tus tareas en la cocina con este robot versátil que hace todo por ti. Desde cortar y picar hasta cocinar y hornear, este dispositivo hace que preparar comidas sea rápido y fácil. Con su amplia gama de funciones y programas preestablecidos, puedes cocinar una variedad de platos con solo presionar un botón. Ya sea que seas un chef experimentado o un principiante en la cocina, este robot te ayuda a crear deliciosas comidas con facilidad y conveniencia.",
                        Price = 511436,
                        Category = 1,
                        ImageUrl = "https://img.pccomponentes.com/articles/32/329974/9743-kenwood-kcook-multi-ccl401wh-robot-de-cocina-multifuncion-1500w-4ef0d08d-31ce-4704-8f55-6e0cfbbce775.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Monitor Gaming ASUS ROG Swift",
                        Description = "Monitor gaming de alta velocidad de actualización y resolución 4K para una experiencia de juego inmersiva. Sumérgete en el mundo del gaming con este monitor que ofrece lo último en rendimiento visual. Con una alta velocidad de actualización, cada movimiento es fluido y sin desenfoques, mientras que la resolución 4K brinda imágenes nítidas y detalladas. Ya sea que estés compitiendo en juegos de acción rápida o explorando mundos virtuales, este monitor te ofrece una experiencia de juego envolvente y emocionante.",
                        Price = 699999,
                        Category = 2,
                        ImageUrl = "https://www.allround-pc.com/wp-content/uploads/2017/02/Asus-ROG-PG258Q-Frontansicht.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Reloj de Pulsera Casio",
                        Description = "Reloj de pulsera resistente al agua con cronómetro y calendario, diseño clásico y duradero. Mantén el tiempo con estilo y funcionalidad con este reloj que combina elegancia y rendimiento. Su resistencia al agua te permite llevarlo en cualquier actividad, mientras que el cronómetro y calendario agregan utilidad adicional. Con un diseño clásico y duradero, este reloj es el complemento perfecto para cualquier ocasión, ya sea en el trabajo, en el gimnasio o en tus aventuras al aire libre.",
                        Price = 84899,
                        Category = 3,
                        ImageUrl = "https://m.media-amazon.com/images/I/71oE44fIffL._AC_UL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Juego de Sábanas de Algodón",
                        Description = "Juego de sábanas de algodón suave y transpirable, incluye sábana bajera, sábana encimera y fundas de almohada. Sumérgete en la comodidad y el lujo con este juego de sábanas que ofrece una experiencia de sueño excepcional. Fabricadas con algodón suave y transpirable, estas sábanas te envuelven en un confort acogedor durante toda la noche. El set completo incluye una sábana bajera ajustable, una sábana encimera y fundas de almohada a juego, garantizando una coordinación perfecta en tu dormitorio. Disfruta de noches de descanso reparador con este juego de sábanas de alta calidad.",
                        Price = 18899,
                        Category = 4,
                        ImageUrl = "https://plazavea.vteximg.com.br/arquivos/ids/1924200-1000-1000/image-227bf6269da546e5b89a752ce83f8841.jpg?v=637595583785970000"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Máscara Facial de Arcilla",
                        Description = "Máscara facial de arcilla purificante para una piel limpia y radiante, adecuada para todo tipo de piel. Renueva tu piel con esta máscara facial que ofrece una limpieza profunda y una sensación de frescura. Formulada con arcilla purificante, ayuda a eliminar impurezas, absorber el exceso de grasa y reducir los poros. Adecuada para todo tipo de piel, esta máscara deja la piel limpia, suave y radiante. Disfruta de una experiencia de spa en casa y revela una tez revitalizada con esta máscara facial rejuvenecedora.",
                        Price = 5999,
                        Category = 5,
                        ImageUrl = "https://i.etsystatic.com/28794076/r/il/1a4dba/3039512871/il_fullxfull.3039512871_4c6l.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Golf Completo",
                        Description = "Set completo de palos de golf con bolsa de transporte, ideal para principiantes y jugadores intermedios. Prepárate para el campo de golf con este set que ofrece todo lo necesario para comenzar a jugar. Con una variedad de palos diseñados para diferentes situaciones en el campo, este set te ayuda a mejorar tu juego. La bolsa de transporte facilita el transporte de tus palos y accesorios. Ya sea que estés dando tus primeros pasos en el golf o buscando mejorar tu habilidad, este set es la elección perfecta para tu próxima partida.",
                        Price = 871200,
                        Category = 6,
                        ImageUrl = "https://th.bing.com/th/id/R.baf0809a66e9feb6bd7448f9cd920e5c?rik=yuY7pmx3%2feSbFA&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Puzzle de 1000 Piezas",
                        Description = "Puzzle de 1000 piezas con imagen de paisaje natural, ideal para entretenimiento en familia o para relajarse. Sumérgete en la belleza de la naturaleza con este rompecabezas que ofrece horas de diversión y relajación. Con 1000 piezas, este puzzle desafía tu mente y estimula tu creatividad mientras recreas una impresionante escena natural. Perfecto para compartir con la familia en una tarde tranquila o para disfrutar en solitario, este rompecabezas es una excelente manera de desconectar y sumergirse en un mundo de paz y serenidad.",
                        Price = 8999,
                        Category = 7,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81syaonDKqL._AC_SL1417_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Whisky Escocés Single Malt",
                        Description = "Botella de whisky escocés single malt de añejamiento prolongado y sabor suave y complejo. Disfruta de la excelencia de la destilería escocesa con esta botella que ofrece una experiencia de sabor excepcional. El proceso de añejamiento prolongado le otorga al whisky una suavidad y complejidad únicas, con notas aromáticas y sabores profundos que deleitan el paladar. Ya sea que lo disfrutes solo, con hielo o en un cóctel, este whisky single malt es la elección perfecta para momentos de celebración y disfrute.",
                        Price = 69999,
                        Category = 8,
                        ImageUrl = "https://drinkland.co.nz/wp-content/uploads/2020/08/Highland-Park-18-Year-Old-Orkney-Single-Malt-Scotch-Whisky-700mL-02.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de Experimentos Científicos para Niños",
                        Description = "Kit de experimentos científicos para niños con actividades educativas y divertidas sobre física, química y biología. Despierta la curiosidad y el interés por la ciencia con este completo kit que ofrece una amplia variedad de experimentos. Desde la exploración de la electricidad y el magnetismo hasta la observación de reacciones químicas y la vida microscópica, cada actividad enseña conceptos fundamentales de manera entretenida. Perfecto para fomentar el aprendizaje interactivo en casa o en el aula, este kit brinda a los niños la oportunidad de explorar y descubrir el fascinante mundo que los rodea."
,
                        Price = 23898,
                        Category = 9,
                        ImageUrl = "https://a0.soysuper.com/f41014ea1c5d020390d2079b835b3f67.1024.0.0.0.wmark.8e20f03f.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Herramientas de Jardinería para Niños",
                        Description = "Set de herramientas de jardinería para niños con rastrillo, pala y regadera, perfecto para actividades al aire libre. Inspira a los pequeños jardineros con este set diseñado especialmente para ellos. Con un rastrillo, una pala y una regadera, los niños pueden explorar y aprender sobre el mundo natural mientras se divierten al aire libre. Este set les brinda la oportunidad de participar en actividades de jardinería de manera segura y educativa, fomentando su amor por la naturaleza y el cuidado del medio ambiente desde una edad temprana.",
                        Price = 23888,
                        Category = 10,
                        ImageUrl = "https://th.bing.com/th/id/OIP.lvDnEJ1bsRI0qh5F2SskmAHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Mochila de Senderismo",
                        Description = "Mochila de senderismo con capacidad de 40 litros y sistema de soporte ergonómico, ideal para excursiones al aire libre. Prepárate para tus aventuras al aire libre con esta mochila diseñada para ofrecer comodidad y funcionalidad. Con su amplia capacidad de 40 litros, puedes llevar todo lo necesario para tus excursiones. El sistema de soporte ergonómico distribuye el peso de manera uniforme, reduciendo la tensión en la espalda y los hombros. Con bolsillos y compartimentos organizativos, esta mochila te permite acceder fácilmente a tus pertenencias mientras exploras la naturaleza.",
                        Price = 124999,
                        Category = 6,
                        ImageUrl = "https://th.bing.com/th/id/OIP.-U9RWQ9p2FVVS23uus1NOwHaHa?w=600&h=600&rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Pistola de Masaje Muscular",
                        Description = "Pistola de masaje muscular con múltiples cabezales intercambiables y ajuste de velocidad, ideal para recuperación después del ejercicio. Acelera tu proceso de recuperación muscular con esta pistola de masaje que ofrece una terapia de percusión efectiva. Equipada con varios cabezales intercambiables, puedes personalizar tu experiencia de masaje según tus necesidades específicas. El ajuste de velocidad te permite controlar la intensidad del masaje, mientras que su diseño ergonómico garantiza un uso cómodo y preciso. Ya sea para aliviar la tensión muscular, mejorar la circulación o reducir el tiempo de recuperación, esta pistola de masaje es tu compañero ideal después del ejercicio.",
                        Price = 43444,
                        Category = 5,
                        ImageUrl = "https://s.libertaddigital.com/2021/05/04/pistola-de-masaje-muscular-hoposo-jmq.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Lámpara de Escritorio LED",
                        Description = "Lámpara de escritorio LED con regulación de intensidad y brazo ajustable, perfecta para estudio o trabajo. Ilumina tu espacio de trabajo con esta lámpara que combina funcionalidad y estilo. Con tecnología LED, ofrece una iluminación brillante y de bajo consumo energético. La regulación de intensidad te permite ajustar la luz según tus necesidades, mientras que el brazo ajustable te proporciona flexibilidad para dirigir la luz hacia donde la necesites. Ya sea para estudiar, trabajar o leer, esta lámpara de escritorio te ofrece la iluminación perfecta para maximizar tu productividad y comodidad.",
                        Price = 19027,
                        Category = 4,
                        ImageUrl = "https://image.biccamera.com/img/00000010204497_A03.jpg?sr.dw=600&sr.jqh=60&sr.dh=600&sr.mat=1"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Té de Porcelana",
                        Description = "Set de té de porcelana con tetera, tazas y platillos, elegante y perfecto para disfrutar de una tarde de té. Eleva tus momentos de té con este exquisito set de porcelana que combina elegancia y funcionalidad. Con una tetera y tazas a juego, junto con platillos coordinados, cada pieza añade un toque de sofisticación a tu ritual de té. Ya sea que disfrutes de una tarde tranquila o invites a amigos a compartir, este set es el compañero ideal para disfrutar de una experiencia de té refinada y memorable.",
                        Price = 175227,
                        Category = 8,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81fFHmBTqgL._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Cámara Mirrorless Sony Alpha",
                        Description = "Cámara mirrorless de alta calidad con sensor APS-C y grabación de video 4K, ideal para fotógrafos aficionados y profesionales. Con su sensor avanzado, esta cámara captura imágenes detalladas y videos nítidos en una variedad de condiciones de iluminación. Su diseño compacto y ligero la hace perfecta para llevarla a todas partes, mientras que sus características avanzadas satisfacen las necesidades de fotógrafos de todos los niveles. Descubre un mundo de posibilidades creativas con esta cámara versátil y potente.",
                        Price = 1399999,
                        Category = 2,
                        Discount = 10,
                        ImageUrl = "https://th.bing.com/th/id/R.095e4965c18d91a4ae3f3136df45c05d?rik=3FJqYjGVT02s1A&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de Maquillaje para Principiantes",
                        Description = "Kit de maquillaje completo para principiantes que incluye productos básicos como base, corrector, sombras y labiales. Con este kit, puedes experimentar y crear looks increíbles fácilmente. Desde una base uniforme hasta unos labios llamativos, todo lo que necesitas está al alcance de tu mano. Perfecto para aprender y explorar el mundo del maquillaje, este kit te ayuda a resaltar tu belleza natural y expresar tu estilo único.",
                        Price = 19898,
                        Category = 5,
                        ImageUrl = "https://d3fa68hw0m2vcc.cloudfront.net/900/171450335.jpeg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Juego de Cubiertos de Acero Inoxidable",
                        Description = "Juego de cubiertos de acero inoxidable para 8 personas, resistente y apto para lavavajillas. Completa tu mesa con este elegante juego de cubiertos que combina funcionalidad y estilo. Fabricado con acero inoxidable de alta calidad, este juego es duradero y resistente a la corrosión. Con capacidad para 8 personas, es perfecto para reuniones familiares o cenas con amigos. Además, su diseño clásico y atemporal se adapta a cualquier ocasión. Disfruta de la conveniencia y la elegancia en cada comida.",
                        Price = 49797,
                        Category = 4,
                        Discount = 5,
                        ImageUrl = "https://th.bing.com/th/id/R.d5388c8d030aa3f391bd815c116ace27?rik=Cjuzlr2DnD7Dlg&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Robot Educativo para Niños",
                        Description = "Robot educativo programable para niños que enseña conceptos de programación y robótica de forma divertida. Este robot interactivo ofrece una experiencia de aprendizaje emocionante, permitiendo a los niños explorar la programación y la robótica de manera práctica y entretenida. Con actividades y desafíos creativos, estimula el pensamiento lógico y fomenta la resolución de problemas. Prepárate para horas de diversión y descubrimiento mientras tus hijos desarrollan habilidades del siglo XXI con este increíble robot educativo.",
                        Price = 30999,
                        Category = 9,
                        Discount = 5,
                        ImageUrl = "https://images-eu.ssl-images-amazon.com/images/I/510gHu9VJ9L.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Bicicleta Estática de Ejercicio",
                        Description = "Bicicleta estática de ejercicio con monitor LCD y resistencia ajustable, ideal para entrenamiento cardiovascular en casa. Con esta bicicleta, puedes mejorar tu salud cardiovascular cómodamente desde casa. El monitor LCD te proporciona datos en tiempo real sobre tu tiempo, distancia, velocidad y calorías quemadas, mientras que la resistencia ajustable te permite personalizar tu entrenamiento. Compacta y fácil de usar, es perfecta para personas de todas las edades y niveles de condición física que deseen mantenerse en forma y saludables.",
                        Price = 181175,
                        Category = 6,
                        Discount = 10,
                        ImageUrl = "https://contents.mediadecathlon.com/p1010256/k$081a10060ffdea37ce7c96e4808c8c43/sq/Bicicleta+Est+tica+Iniciaci+n+Domyos+Essential.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de Sushi Casero",
                        Description = "Kit completo para hacer sushi en casa, incluye moldes, esterilla de bambú y utensilios para preparar sushi de calidad profesional. Con este kit, puedes disfrutar de deliciosos rollos de sushi caseros como un verdadero chef. Los moldes facilitan la creación de rollos perfectamente formados, mientras que la esterilla de bambú te ayuda a enrollar el sushi con precisión. Además, los utensilios de calidad profesional garantizan un acabado impecable en cada bocado. Sorprende a tus invitados o simplemente disfruta de una comida japonesa auténtica en la comodidad de tu hogar.",
                        Price = 19099,
                        Category = 8,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81Dk-MyDZEL._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Manicura y Pedicura",
                        Description = "Set de manicura y pedicura profesional con cortaúñas, limas y otros accesorios para el cuidado de las uñas. Mantén tus manos y pies impecables con este completo set de herramientas de belleza. Incluye todo lo necesario para lograr unas uñas perfectamente cuidadas: cortaúñas, limas, empujadores de cutículas y más. Fabricado con materiales de alta calidad, es ideal tanto para uso doméstico como profesional. Disfruta de uñas bien cuidadas y una apariencia elegante con este set de manicura y pedicura.",
                        Price = 8988,
                        Category = 5,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/715w9eYZeCL._AC_SL1400_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Tablero de Ajedrez de Madera",
                        Description = "Tablero de ajedrez de madera de alta calidad, ideal para partidas en casa o en torneos. Disfruta del noble juego del ajedrez con este tablero meticulosamente elaborado. Fabricado con madera duradera, ofrece una superficie lisa y resistente para tus partidas. Su diseño clásico y elegante lo convierte en una pieza destacada en cualquier ambiente. Ya sea para practicar estrategias en casa o competir en torneos, este tablero garantiza una experiencia de juego excepcional.",
                        Price = 15606,
                        Category = 7,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81q-sAnjp9L._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Sartén Antiadherente de Titanio",
                        Description = "Sartén antiadherente de titanio con mango ergonómico y revestimiento resistente a rayones, ideal para cocinar sin que los alimentos se peguen. Con esta sartén, disfruta de una cocina más saludable y fácil. El revestimiento antiadherente de titanio garantiza una cocción uniforme y sin problemas, mientras que el mango ergonómico proporciona un agarre cómodo y seguro. Además, su revestimiento resistente a rayones asegura una durabilidad excepcional. Cocina con facilidad y disfruta de resultados perfectos en cada comida.",
                        Price = 73999,
                        Category = 4,
                        ImageUrl = "https://topsartenes.com/wp-content/uploads/2018/08/Tefal-Emotion-Sart%C3%A9n-de-Aluminio-de-20-cm-Antiadherente-Titanium-Extra-1024x482.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Altavoz Bluetooth Portátil",
                        Description = "Altavoz Bluetooth portátil con sonido estéreo de alta calidad y batería de larga duración, perfecto para llevar la música a todas partes. Disfruta de una experiencia auditiva inigualable con este altavoz compacto y potente. Conecta tu dispositivo Bluetooth y disfruta de un sonido estéreo claro y envolvente dondequiera que vayas. Además, su batería de larga duración te permite disfrutar de horas de música sin interrupciones. Ya sea en casa, al aire libre o de viaje, este altavoz es tu compañero perfecto para disfrutar de tu música favorita.",
                        Price = 26000,
                        Category = 2,
                        ImageUrl = "https://topesdegama.com/app/uploads-topesdegama.com/2019/08/Altavoz-Bluetooth-1-2.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Técnica de Dibujo a Lápiz",
                        Description = "Set de técnicas de dibujo a lápiz que incluye lápices de diferentes durezas, goma de borrar y bloc de dibujo, ideal para artistas principiantes y avanzados. Con este completo set, podrás explorar tu creatividad y mejorar tus habilidades de dibujo. Los lápices de diferentes durezas te permiten crear una amplia gama de efectos y detalles, mientras que la goma de borrar te ayuda a corregir errores fácilmente. Además, el bloc de dibujo ofrece una superficie de calidad para plasmar tus ideas. Ya seas principiante o avanzado, este set es una herramienta indispensable para expresar tu arte.",
                        Price = 6275,
                        Category = 9,
                        ImageUrl = "https://th.bing.com/th/id/OIP.EOq0y7VygS2aCBA-zQND4AHaF4?w=680&h=540&rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Caja de Herramientas de Mano",
                        Description = "Caja de herramientas de mano con destornilladores, llaves ajustables y otras herramientas esenciales para tareas de bricolaje y reparaciones en el hogar. Prepárate para cualquier proyecto con este completo conjunto de herramientas. Incluye destornilladores de diferentes tamaños y tipos, llaves ajustables, alicates y más, todo organizado en una práctica caja de almacenamiento. Ya sea que necesites apretar tornillos sueltos, colgar cuadros o realizar reparaciones menores, este conjunto te ofrece las herramientas necesarias para hacer el trabajo de manera eficiente y efectiva.",
                        Price = 49999,
                        Category = 10,
                        ImageUrl = "https://m.media-amazon.com/images/I/71rpqADybwL._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Telescopio Astronómico",
                        Description = "Telescopio astronómico refractor con aumento ajustable y trípode estable, ideal para observaciones astronómicas amateurs. Descubre el universo desde la comodidad de tu hogar con este telescopio de alta calidad. Su diseño refractor ofrece imágenes claras y nítidas de objetos celestes, mientras que el aumento ajustable te permite explorar diferentes detalles del cosmos. El trípode estable garantiza una observación sin vibraciones, mientras que su portabilidad te permite llevarlo a tus lugares de observación favoritos. Prepárate para explorar el cielo nocturno con este telescopio diseñado para entusiastas de la astronomía.",
                        Price = 112099,
                        Category = 6,
                        Discount = 10,
                        ImageUrl = "https://http2.mlstatic.com/telescopio-profissional-refrator-luneta-90x-terrestre-lunar-D_NQ_NP_723071-MLB29216368215_012019-F.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Acondicionador de Aire Portátil",
                        Description = "Acondicionador de aire portátil con control remoto y temporizador, adecuado para espacios pequeños y medianos. Mantén tu hogar fresco y confortable con este práctico acondicionador de aire. Con su diseño portátil, puedes llevarlo fácilmente a cualquier habitación que necesite refrigeración. El control remoto y el temporizador te permiten ajustar la temperatura y programar el funcionamiento según tus preferencias. Ideal para espacios pequeños y medianos, este acondicionador de aire ofrece una solución eficaz para combatir el calor durante los meses más calurosos del año.",
                        Price = 483867,
                        Category = 1,
                        Discount = 20,
                        ImageUrl = "https://images.deprati.com.ec/sys-master/images/hf8/h01/9954234073118/14224384-0_product_1200Wx1800H"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Pinceles de Maquillaje",
                        Description = "Set de pinceles de maquillaje de alta calidad para aplicar bases, sombras de ojos, rubor y más, diseñado para una aplicación precisa. Crea looks impecables con este set de pinceles que cubre todas tus necesidades de maquillaje. Con una variedad de formas y tamaños, estos pinceles te permiten aplicar y difuminar productos de manera uniforme y profesional. Fabricados con materiales de alta calidad, son suaves en la piel y duraderos. Eleva tu rutina de belleza con estos pinceles imprescindibles que te ayudarán a lograr resultados de aspecto impecable.",
                        Price = 15000,
                        Category = 5,
                        ImageUrl = "https://www.theoria.fr/wp-content/uploads/2020/11/71wtJakwpmL._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Caja de Herramientas Eléctricas",
                        Description = "Caja de herramientas eléctricas que incluye taladro, sierra circular y otras herramientas esenciales para proyectos de bricolaje y construcción. Con este completo conjunto de herramientas eléctricas, estarás preparado para abordar una amplia gama de proyectos en el hogar. El taladro te permite perforar agujeros con precisión, mientras que la sierra circular facilita el corte de materiales como madera y metal. Además, otras herramientas incluidas te ayudarán a completar tareas de manera eficiente y profesional. Simplifica tus proyectos de bricolaje y construcción con esta caja de herramientas eléctricas todo en uno.",
                        Price = 250999,
                        Category = 10,
                        Discount = 10,
                        ImageUrl = "https://th.bing.com/th/id/OIP.OjhDY_0zOATiXAGtZyMQvgHaGN?rs=1&pid=ImgDetMain"

                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Piano Digital Yamaha",
                        Description = "Piano digital con teclas contrapesadas y múltiples voces y efectos, perfecto para principiantes y pianistas avanzados. Este piano ofrece una experiencia de interpretación auténtica con teclas contrapesadas que simulan la sensación de un piano acústico. Con una amplia variedad de voces y efectos, puedes explorar diferentes estilos musicales y expresar tu creatividad. Además, su diseño compacto lo hace ideal para espacios reducidos. Ya seas principiante o avanzado, este piano digital te brinda las herramientas necesarias para desarrollar tus habilidades musicales y disfrutar de horas de práctica y entretenimiento.",
                        Price = 1545180,
                        Category = 6,
                        Discount = 14,
                        ImageUrl = "https://th.bing.com/th/id/R.16e5658bba363d72e7a3126bb6e69cd3?rik=8%2bjXEPN7vtQlmg&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Caja de Vino Tinto Reserva",
                        Description = "Caja de vino tinto reserva con selección de las mejores añadas y variedades, ideal para ocasiones especiales y regalos. Disfruta de una experiencia enológica excepcional con esta cuidadosa selección de vinos. Cada botella representa lo mejor de su cosecha, ofreciendo una mezcla única de sabores y aromas. Perfecta para celebrar ocasiones especiales o como regalo para amigos y familiares, esta caja de vino reserva añade un toque de elegancia a cualquier evento. Sorprende a tus seres queridos con esta exquisita selección y comparte momentos memorables alrededor de una copa de vino.",
                        Price = 29999,
                        Category = 8,
                        Discount = 5,
                        ImageUrl = "https://sgfm.elcorteingles.es/SGFM/dctm/MEDIA03/202001/27/00118718001250____7__1200x1200.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de Maquillaje de Labios",
                        Description = "Kit de maquillaje de labios con una variedad de colores y acabados, incluye barras de labios líquidas y labiales en barra. Explora un mundo de opciones de maquillaje para tus labios con este completo kit. Desde tonos vibrantes hasta sutiles acabados mate, encontrarás el color perfecto para cada ocasión. Las barras de labios líquidas ofrecen una aplicación suave y de larga duración, mientras que los labiales en barra proporcionan un acabado cremoso y confortable. Añade un toque de color y estilo a tu look diario con este versátil kit de maquillaje de labios.",
                        Price = 11999,
                        Category = 5,
                        ImageUrl = "https://th.bing.com/th/id/OIP.T9jtfnpiu8aLb93zXZx02gHaFj?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Tazas de Café de Porcelana",
                        Description = "Set de tazas de café de porcelana con diseño elegante y moderno, ideal para disfrutar del café en casa o en la oficina. Eleva tu experiencia de café con este conjunto de tazas que combinan estilo y funcionalidad. Fabricadas con porcelana de alta calidad, estas tazas ofrecen una apariencia elegante y una sensación confortable al sostenerlas. Con su diseño moderno, son el complemento perfecto para cualquier decoración de cocina u oficina. Disfruta de momentos de tranquilidad con una taza de café perfectamente servida en este set de tazas excepcional.",
                        Price = 34087,
                        Category = 8,
                        ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_962633-MLB45600780976_042021-F.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de Cuidado de Barba",
                        Description = "Kit de cuidado de barba que incluye aceite, bálsamo, peine y tijeras, ideal para mantener la barba suave y bien cuidada. Haz que tu barba luzca impecable con este completo kit de cuidado. El aceite y el bálsamo nutren e hidratan la barba, manteniéndola suave y con un aspecto saludable. El peine y las tijeras te permiten dar forma y estilizar tu barba con precisión. Ya sea que tengas una barba corta o larga, este kit es esencial para mantenerla en óptimas condiciones y lucir siempre impecable.",
                        Price = 22799,
                        Category = 5,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91X5mdnG9%2BL._SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Juegos de Mesa",
                        Description = "Set de juegos de mesa clásicos que incluye ajedrez, damas y backgammon, perfecto para disfrutar en familia o con amigos. Reúnete alrededor de la diversión con este versátil set que ofrece horas de entretenimiento. Tres juegos clásicos en un solo conjunto, brindando variedad y emoción para todas las edades. Desde estrategias complejas en el ajedrez hasta la diversión tradicional de las damas y la emoción del backgammon, hay algo para todos. Aprovecha la oportunidad para crear recuerdos memorables y fortalecer los lazos familiares y de amistad con este completo set de juegos de mesa.",
                        Price = 19999,
                        Category = 7,
                        ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_677379-MLC44163778741_112020-F.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Lámpara de Pie Moderna",
                        Description = "Lámpara de pie moderna con pantalla ajustable y luz regulable, ideal para iluminar cualquier espacio de forma elegante. Agrega un toque de estilo y funcionalidad a tu hogar con esta lámpara de pie contemporánea. Su pantalla ajustable te permite dirigir la luz según tus necesidades, mientras que la función de luz regulable te permite crear diferentes ambientes según el momento del día. Ya sea en el salón, la oficina o el dormitorio, esta lámpara ofrece una iluminación versátil y sofisticada que complementa cualquier decoración. Disfruta de un ambiente acogedor y bien iluminado con esta lámpara moderna y elegante.",
                        Price = 24500,
                        Category = 4,
                        ImageUrl = "https://mla-s1-p.mlstatic.com/786581-MLA26434101358_112017-B.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Juego de Cuchillos de Chef",
                        Description = "Juego de cuchillos de chef profesionales con hojas de acero inoxidable y mangos ergonómicos, perfectos para cortar y picar con precisión. Equipa tu cocina con este juego de cuchillos de alta calidad que hacen que la preparación de alimentos sea más fácil y precisa. Las hojas de acero inoxidable mantienen su filo durante más tiempo y ofrecen un corte limpio y preciso. Los mangos ergonómicos proporcionan un agarre cómodo y seguro, reduciendo la fatiga durante el uso prolongado. Ya seas un chef profesional o un entusiasta de la cocina en casa, este juego de cuchillos es imprescindible para tu colección de utensilios de cocina.",
                        Price = 37555,
                        Category = 4,
                        ImageUrl = "https://img-static.insania.com/imagens/50000/5875/04.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Cucharas Medidoras",
                        Description = "Set de cucharas medidoras de cocina en diferentes tamaños, perfecto para medir ingredientes con precisión al cocinar. Simplifica tus preparaciones culinarias con este práctico set de cucharas medidoras. Con una variedad de tamaños, desde cucharaditas hasta cucharadas, te permite medir con precisión cada ingrediente según las indicaciones de tus recetas. Fabricadas con materiales duraderos y fáciles de limpiar, estas cucharas son indispensables en cualquier cocina. Ya sea que estés horneando, cocinando o preparando bebidas, este set te garantiza resultados perfectos en cada ocasión.",
                        Price = 6999,
                        Category = 1,
                        ImageUrl = "https://th.bing.com/th/id/OIP.YnBwconuCDmzHmHqnv6SAwHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Bolsa de Viaje Resistente al Agua",
                        Description = "Bolsa de viaje resistente al agua con múltiples compartimentos y correa ajustable, ideal para viajes cortos o escapadas de fin de semana. Prepárate para tus aventuras con esta bolsa versátil que combina funcionalidad y estilo. Su diseño resistente al agua protege tus pertenencias de la lluvia y la humedad, mientras que los múltiples compartimentos te permiten organizar tus cosas de manera eficiente. Con una correa ajustable, puedes llevarla cómodamente sobre el hombro o cruzada. Ya sea para una escapada de fin de semana o un viaje corto, esta bolsa es el compañero perfecto para tus desplazamientos.",
                        Price = 25000,
                        Category = 4,
                        ImageUrl = "https://th.bing.com/th/id/OIP.M1clNbkMiqw3Qlm7w1FstAHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Monitor de Actividad Física",
                        Description = "Monitor de actividad física con seguimiento de pasos, distancia, calorías quemadas y monitorización del sueño, ideal para mantener un estilo de vida saludable. Mantén un registro detallado de tu actividad diaria con este monitor que te ayuda a alcanzar tus objetivos de bienestar. Registra tus pasos, la distancia recorrida y las calorías quemadas para mantenerte en movimiento. Además, monitoriza la calidad de tu sueño para asegurar un descanso reparador. Con su diseño ergonómico y funciones avanzadas, este monitor es tu compañero perfecto para alcanzar un estilo de vida más saludable y activo.",
                        Price = 270669,
                        Category = 6,
                        Discount = 5,
                        ImageUrl = "https://th.bing.com/th/id/OIP.6uxVrzkzA4v387JSzflFygHaHN?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Platos de Cerámica",
                        Description = "Set de platos de cerámica para servir comidas con estilo, resistente y apto para lavavajillas, ideal para uso diario o ocasiones especiales. Dale un toque de elegancia a tu mesa con este set de platos que combina funcionalidad y diseño. Fabricados con cerámica duradera, estos platos son resistentes y pueden soportar el uso diario. Además, su acabado apto para lavavajillas facilita la limpieza después de cada comida. Ya sea para una cena informal en casa o una ocasión especial, este set de platos es perfecto para servir tus platos favoritos con estilo.",
                        Price = 55000,
                        Category = 4,
                        Discount = 2,
                        ImageUrl = "https://th.bing.com/th/id/OIP.p9WgOXbClrrXRrQaLmW-EwHaHa?w=1500&h=1500&rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Toallas de Baño de Algodón",
                        Description = "Set de toallas de baño de algodón suave y absorbente, incluye toalla de baño, toalla de mano y toalla facial. Envuélvete en lujo y comodidad con este set de toallas que ofrece una experiencia de baño indulgente. Fabricadas con algodón de alta calidad, estas toallas son suaves al tacto y altamente absorbentes, proporcionando una sensación de frescura después de cada baño. Con tamaños adecuados para cada necesidad, desde la toalla de baño hasta la toalla facial, este set es imprescindible para cualquier baño bien equipado. Disfruta de la suavidad y la calidad que estas toallas brindan a tu rutina diaria de cuidado personal.",
                        Price = 20000,
                        Category = 4,
                        Discount = 2,
                        ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_2X_655053-MLM40882494688_022020-F.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Bolígrafos de Gel de Colores",
                        Description = "Set de bolígrafos de gel de colores vivos y tinta de secado rápido, perfectos para tomar notas y hacer dibujos creativos. Desata tu creatividad con este conjunto de bolígrafos que ofrecen una escritura suave y vibrante. Con una variedad de colores brillantes, puedes añadir un toque de color a tus notas, dibujos y proyectos artísticos. Además, la tinta de secado rápido evita manchas y borrones, garantizando resultados impecables. Ya sea en la escuela, el trabajo o en casa, estos bolígrafos son la elección ideal para expresarte de forma creativa y hacer que tus ideas cobren vida.",
                        Price = 12999,
                        Category = 9,
                        ImageUrl = "https://th.bing.com/th/id/R.fbee547f59ddd79676e87d29bcde5881?rik=ycY9mXzLL9d9BA&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Reloj Despertador Digital",
                        Description = "Reloj despertador digital con pantalla LED y funciones de alarma y calendario, ideal para despertarse con precisión. Empieza tu día con este práctico despertador que te ofrece una forma confiable de despertarte a tiempo. Con su pantalla LED brillante, muestra la hora, la fecha y la configuración de alarma de forma clara y fácil de leer. Además, las funciones de alarma te permiten establecer múltiples alarmas para adaptarse a tus horarios. Ya sea en tu mesita de noche o en tu escritorio, este reloj despertador es una adición funcional y elegante a tu rutina matutina.",
                        Price = 19999,
                        Category = 4,
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/61juK0Qhp6L._AC_SL1500_.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Juego de Destornilladores de Precisión",
                        Description = "Juego de destornilladores de precisión con puntas intercambiables y mango antideslizante, ideal para reparaciones delicadas. Haz frente a trabajos de precisión con confianza utilizando este completo juego de destornilladores. Sus puntas intercambiables te permiten adaptarte a una variedad de tamaños y tipos de tornillos, mientras que el mango antideslizante garantiza un agarre firme y cómodo durante el uso. Ya sea que estés reparando dispositivos electrónicos, juguetes o relojes, este juego de destornilladores es imprescindible para cualquier aficionado o profesional que requiera precisión y fiabilidad en sus trabajos.",
                        Price = 5000,
                        Category = 10,
                        ImageUrl = "https://th.bing.com/th/id/OIP.8biKpp24on-_MKc-ICiqdwHaIS?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Cámara de Seguridad WiFi",
                        Description = "Cámara de seguridad WiFi con visión nocturna y detección de movimiento, ideal para monitorear tu hogar o negocio desde cualquier lugar. Mantén tu propiedad segura y protegida con esta cámara de seguridad avanzada que ofrece características de vanguardia. Con su conexión WiFi, puedes acceder al video en tiempo real desde tu teléfono inteligente o computadora, incluso cuando estás fuera de casa. La visión nocturna te permite mantener la vigilancia durante la noche, mientras que la detección de movimiento te alerta instantáneamente sobre cualquier actividad sospechosa. Con esta cámara, disfruta de una tranquilidad total al saber que puedes estar al tanto de lo que sucede en tu entorno en todo momento.",
                        Price = 58399,
                        Category = 4,
                        Discount = 10,
                        ImageUrl = "https://th.bing.com/th/id/OIP.IzJ0VcLsuEXb37n2OmILKQHaJL?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Plancha de Pelo Cerámica",
                        Description = "Plancha de pelo con placas de cerámica y ajuste de temperatura, perfecta para alisar o rizar el cabello de forma segura. Obtén resultados profesionales en la comodidad de tu hogar con esta plancha de pelo de alta calidad. Sus placas de cerámica proporcionan un calor uniforme que protege tu cabello del daño por calor, mientras que el ajuste de temperatura te permite adaptarla a tu tipo de cabello. Ya sea que desees un cabello liso y sedoso o unos rizos sueltos y definidos, esta plancha es tu aliada para lograr el estilo que desees de manera segura y eficiente.",
                        Price = 22499,
                        Category = 5,
                        Discount = 6,
                        ImageUrl = "https://www.joopzy.com/wp-content/uploads/2017/12/primary-1.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Kit de Iniciación a la Pintura al Óleo",
                        Description = "Kit de iniciación a la pintura al óleo que incluye lienzos, pinturas y pinceles, ideal para artistas principiantes. Da tus primeros pasos en el mundo del arte con este completo kit que proporciona todo lo necesario para empezar a pintar al óleo. Los lienzos de calidad ofrecen una superficie perfecta para plasmar tu creatividad, mientras que las pinturas vibrantes te permiten experimentar con una amplia gama de colores. Además, los pinceles incluidos te ayudan a aplicar la pintura con precisión y detalle. Ya sea que estés explorando tu talento artístico o buscando una nueva afición, este kit es el punto de partida perfecto para tu viaje creativo.",
                        Price = 9736,
                        Category = 9,
                        Discount = 4,
                        ImageUrl = "https://a0.soysuper.com/5a574d66498bf9c0b98a1dd06ca83083.1500.0.0.0.wmark.0b04d770.jpg"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Máquina de Café Espresso",
                        Description = "Máquina de café espresso automática con vaporizador de leche, ideal para preparar café de alta calidad en casa. Disfruta de la experiencia de una cafetería en la comodidad de tu hogar con esta máquina de café espresso de última generación. Con su funcionamiento automático, puedes preparar fácilmente deliciosos espressos, cappuccinos y lattes con solo tocar un botón. El vaporizador de leche te permite crear una espuma cremosa para tus bebidas favoritas. Además, su diseño elegante y compacto se adapta perfectamente a cualquier cocina. Eleva tu rutina matutina con café de alta calidad preparado al instante con esta máquina de café espresso automática.",
                        Price = 236550,
                        Category = 8,
                        Discount = 10,
                        ImageUrl = "https://th.bing.com/th/id/OIP.Rdeajhi-q30zNGPlcQvG5gHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Brochas de Maquillaje Profesional",
                        Description = "Set de brochas de maquillaje profesional con cerdas suaves y duraderas, ideal para aplicar maquillaje de forma precisa. Experimenta un acabado impecable con este completo set de brochas que ofrece todo lo necesario para crear looks de maquillaje profesionales. Las cerdas suaves y resistentes garantizan una aplicación uniforme y sin rayas, mientras que los mangos ergonómicos proporcionan un agarre cómodo y controlado. Desde la base hasta los detalles, cada brocha está diseñada para brindar precisión y versatilidad en cada paso de tu rutina de maquillaje. Eleva tu juego de maquillaje con este set de brochas imprescindible que te ayuda a lograr resultados de aspecto profesional.",
                        Price = 8999,
                        Category = 5,
                        Discount = 5,
                        ImageUrl = "https://th.bing.com/th/id/R.784d7e06420f061c505e49af947d5f2f?rik=RQ8Nqsk6zcrztg&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Juego de Mesa de Estrategia Battleship",
                        Description = "Juego de mesa de estrategia que desafía tu mente y habilidades estratégicas, perfecto para partidas emocionantes con amigos o familiares. Sumérgete en la emoción y el desafío de este juego que pondrá a prueba tus capacidades de planificación y táctica. Con reglas simples pero profundas, ofrece horas de diversión competitiva para jugadores de todas las edades. Desde movimientos calculados hasta decisiones estratégicas, cada partida es una oportunidad para mejorar tus habilidades y superar a tus oponentes. Reúne a tus seres queridos y prepárate para emocionantes encuentros llenos de intriga y suspense con este juego de mesa que garantiza diversión sin fin.",
                        Price = 11000,
                        Category = 7,
                        Discount = 5,
                        ImageUrl = "https://th.bing.com/th/id/OIP.TYIWsTfGwGGq6vtdCUT7kwHaHa?rs=1&pid=ImgDetMain"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Silla de Oficina Ergonómica",
                        Description = "Silla de oficina ergonómica con respaldo ajustable y soporte lumbar, diseñada para proporcionar comodidad durante largas horas de trabajo. Optimiza tu espacio de trabajo con esta silla diseñada pensando en tu comodidad y bienestar. Su respaldo ajustable y soporte lumbar te permiten encontrar la posición perfecta para mantener una postura saludable durante todo el día. Además, su diseño ergonómico reduce la fatiga y el malestar, permitiéndote concentrarte en tus tareas con mayor eficiencia. Ya sea en la oficina o en casa, esta silla es la compañera ideal para afrontar jornadas laborales prolongadas con confort y estilo.",
                        Price = 199999,
                        Category = 4,
                        Discount = 10,
                        ImageUrl = "https://th.bing.com/th/id/R.ae0f38a9f4e01157bf8c01741e09b469?rik=Efl%2fqCQ9eMdfOw&pid=ImgRaw&r=0"
                    },
                    new Product
                    {
                        ProductId = Guid.NewGuid(),
                        Name = "Set de Herramientas para Barbacoa",
                        Description = "Set de herramientas para barbacoa que incluye pinzas, espátula y cepillo, perfecto para preparar deliciosas parrilladas al aire libre. Haz de tus reuniones al aire libre toda una experiencia culinaria con este completo set de herramientas para barbacoa. Las pinzas te permiten voltear con precisión los alimentos, mientras que la espátula facilita el manejo de hamburguesas y filetes. Además, el cepillo de limpieza te ayuda a mantener la parrilla en óptimas condiciones. Con este set, estarás listo para enfrentar cualquier desafío culinario y sorprender a tus invitados con deliciosas y perfectamente cocidas parrilladas.",
                        Price = 8800,
                        Category = 8,
                        Discount = 2,
                        ImageUrl = "https://th.bing.com/th/id/OIP.9O10qR5yY6KGJobxv42YhwHaHa?rs=1&pid=ImgDetMain"
                    }
            );
        }
    }
}
