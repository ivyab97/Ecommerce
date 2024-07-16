﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPay = table.Column<decimal>(type: "decimal(18,4)", nullable: false, defaultValue: 0m),
                    Subtotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false, defaultValue: 0m),
                    TotalDiscount = table.Column<decimal>(type: "decimal(18,4)", nullable: false, defaultValue: 0m),
                    Taxes = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 1.21m),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.SaleId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Category_Category",
                        column: x => x.Category,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleProduct",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sale = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleProduct", x => x.ShoppingCartId);
                    table.ForeignKey(
                        name: "FK_SaleProduct_Product_Product",
                        column: x => x.Product,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleProduct_Sale_Sale",
                        column: x => x.Sale,
                        principalTable: "Sale",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Electrodomésticos" },
                    { 2, "Tecnología y Electrónica" },
                    { 3, "Moda y Accesorios" },
                    { 4, "Hogar y Decoración" },
                    { 5, "Salud y Belleza" },
                    { 6, "Deportes y Ocio" },
                    { 7, "Juguetes y Juegos" },
                    { 8, "Alimentos y Bebidas" },
                    { 9, "Libros y Material Educativo" },
                    { 10, "Jardinería y Bricolaje" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("00aa2a5d-1e41-46f5-b00d-e47ca025e4b1"), 1, "Cafetera espresso automática con sistema de espuma de leche y selección de intensidad. Disfruta del café perfecto en casa con esta cafetera que combina conveniencia y calidad. El sistema de espuma de leche te permite crear capuchinos y lattes cremosos, mientras que la selección de intensidad te permite personalizar tu bebida según tus preferencias. Con un diseño elegante y fácil de usar, es ideal para los amantes del café que buscan comodidad y sabor excepcionales.", "https://th.bing.com/th/id/OIP.A6cDZMQZT-3N_VGtAchTBAHaHa?rs=1&pid=ImgDetMain", "Cafetera Espresso De'Longhi", 233988m },
                    { new Guid("049bea5c-9ed2-46f8-b9e1-6eb74b824797"), 5, "Set de manicura y pedicura profesional con cortaúñas, limas y otros accesorios para el cuidado de las uñas. Mantén tus manos y pies impecables con este completo set de herramientas de belleza. Incluye todo lo necesario para lograr unas uñas perfectamente cuidadas: cortaúñas, limas, empujadores de cutículas y más. Fabricado con materiales de alta calidad, es ideal tanto para uso doméstico como profesional. Disfruta de uñas bien cuidadas y una apariencia elegante con este set de manicura y pedicura.", "https://images-na.ssl-images-amazon.com/images/I/715w9eYZeCL._AC_SL1400_.jpg", "Set de Manicura y Pedicura", 8988m },
                    { new Guid("05cc9d85-7ee5-431d-9a01-7c3a03e0ccfa"), 8, "Caja de vinos varietales seleccionados, incluye 6 botellas de diferentes cepas. Descubre una selección excepcional de vinos que deleitarán tu paladar con esta caja cuidadosamente elegida. Con seis botellas de diferentes cepas, desde tintos robustos hasta blancos refrescantes, esta colección ofrece una experiencia de degustación diversa y emocionante. Perfecta para disfrutar en reuniones sociales o para regalar a los amantes del vino, esta caja es una elección elegante y sofisticada.", "https://images-na.ssl-images-amazon.com/images/I/81Wsb4Blr%2BL._AC_SY741_.jpg", "Caja de Vinos Varietales", 34500m },
                    { new Guid("0d0f9105-da8a-4096-9d8b-01c02c916d39"), 3, "Bolso de mano elegante hecho de cuero genuino con diseño clásico. Añade un toque de sofisticación a tu estilo con este bolso de mano de alta calidad. Fabricado con cuero genuino, ofrece durabilidad y estilo atemporal. Su diseño clásico complementa cualquier outfit, ya sea casual o formal. Con espacio suficiente para tus esenciales diarios, es perfecto para el trabajo, las citas o las ocasiones especiales. Haz una declaración de elegancia con este bolso de mano exclusivo.", "https://www.cuiroma.com/1610-large_default/bolso-de-cuero-genuino.jpg", "Bolso de Cuero Genuino", 90000m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("0d4f2141-bf0d-480b-bd40-f54fbaa03de8"), 8, "Set de herramientas para barbacoa que incluye pinzas, espátula y cepillo, perfecto para preparar deliciosas parrilladas al aire libre. Haz de tus reuniones al aire libre toda una experiencia culinaria con este completo set de herramientas para barbacoa. Las pinzas te permiten voltear con precisión los alimentos, mientras que la espátula facilita el manejo de hamburguesas y filetes. Además, el cepillo de limpieza te ayuda a mantener la parrilla en óptimas condiciones. Con este set, estarás listo para enfrentar cualquier desafío culinario y sorprender a tus invitados con deliciosas y perfectamente cocidas parrilladas.", 2, "https://th.bing.com/th/id/OIP.9O10qR5yY6KGJobxv42YhwHaHa?rs=1&pid=ImgDetMain", "Set de Herramientas para Barbacoa", 8800m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0ddc8ba2-4cc5-462d-936e-9e0bc7d6f367"), 4, "Reloj despertador digital con pantalla LED y funciones de alarma y calendario, ideal para despertarse con precisión. Empieza tu día con este práctico despertador que te ofrece una forma confiable de despertarte a tiempo. Con su pantalla LED brillante, muestra la hora, la fecha y la configuración de alarma de forma clara y fácil de leer. Además, las funciones de alarma te permiten establecer múltiples alarmas para adaptarse a tus horarios. Ya sea en tu mesita de noche o en tu escritorio, este reloj despertador es una adición funcional y elegante a tu rutina matutina.", "https://images-na.ssl-images-amazon.com/images/I/61juK0Qhp6L._AC_SL1500_.jpg", "Reloj Despertador Digital", 19999m },
                    { new Guid("0f31e1e8-0f59-4fd8-a3c1-bab5b73c1b97"), 2, "Auriculares inalámbricos Bluetooth con cancelación de ruido activa. Sumérgete en tu música favorita con estos auriculares que ofrecen una experiencia auditiva excepcional. La tecnología Bluetooth te permite una conexión sin cables, mientras que la cancelación de ruido activa bloquea el ruido exterior para una inmersión total. Con un diseño ergonómico y controles intuitivos, disfruta de la libertad y la calidad de sonido en cualquier lugar.", "https://www.bhphotovideo.com/images/images2500x2500/sony_wh1000xm4_b_wh_1000xm4_wireless_noise_canceling_over_ear_1582549.jpg", "Auriculares Sony WH-1000XM4", 89999m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("107c4bc4-2ba2-4b29-b4b3-72fe64138ee7"), 6, "Telescopio astronómico refractor con aumento ajustable y trípode estable, ideal para observaciones astronómicas amateurs. Descubre el universo desde la comodidad de tu hogar con este telescopio de alta calidad. Su diseño refractor ofrece imágenes claras y nítidas de objetos celestes, mientras que el aumento ajustable te permite explorar diferentes detalles del cosmos. El trípode estable garantiza una observación sin vibraciones, mientras que su portabilidad te permite llevarlo a tus lugares de observación favoritos. Prepárate para explorar el cielo nocturno con este telescopio diseñado para entusiastas de la astronomía.", 10, "https://http2.mlstatic.com/telescopio-profissional-refrator-luneta-90x-terrestre-lunar-D_NQ_NP_723071-MLB29216368215_012019-F.jpg", "Telescopio Astronómico", 112099m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("115a616b-27cb-4be9-9a43-03de5023b99e"), 8, "Botella de vino tinto reserva con cuerpo y sabor intensos, perfecto para ocasiones especiales. Celebra momentos memorables con esta exquisita botella de vino tinto reserva. Con su cuerpo robusto y sabor profundo, esta selección ofrece una experiencia sensorial única que deleitará a los aficionados del vino. Ya sea para una cena romántica, una celebración familiar o un regalo especial, esta botella añade un toque de elegancia y sofisticación a cualquier ocasión.", "https://th.bing.com/th/id/OIP.IxKFqPXn8UebJyd8u-TBAgHaHa?rs=1&pid=ImgDetMain", "Vino Tinto Reserva", 30999m },
                    { new Guid("150fac7e-7556-4b6e-8277-4578a2c3af99"), 7, "Puzzle de 1000 piezas con imagen de paisaje natural, ideal para entretenimiento en familia o para relajarse. Sumérgete en la belleza de la naturaleza con este rompecabezas que ofrece horas de diversión y relajación. Con 1000 piezas, este puzzle desafía tu mente y estimula tu creatividad mientras recreas una impresionante escena natural. Perfecto para compartir con la familia en una tarde tranquila o para disfrutar en solitario, este rompecabezas es una excelente manera de desconectar y sumergirse en un mundo de paz y serenidad.", "https://images-na.ssl-images-amazon.com/images/I/81syaonDKqL._AC_SL1417_.jpg", "Puzzle de 1000 Piezas", 8999m },
                    { new Guid("1757701e-4c30-4efb-80d4-f6d9874d6848"), 5, "Secador de pelo iónico con difusor y concentrador de aire. Obtén resultados profesionales desde la comodidad de tu hogar con este secador de pelo avanzado. La tecnología iónica reduce el frizz y mejora la suavidad y brillo de tu cabello. El difusor es ideal para cabello rizado o con ondas, mientras que el concentrador de aire permite un secado preciso. Dale a tu cabello el cuidado que se merece con este secador de alto rendimiento.", "https://images-na.ssl-images-amazon.com/images/I/61zQL-2rpzL._AC_SL1500_.jpg", "Secador de Pelo Remington Ionic", 58831m },
                    { new Guid("19027f83-3d9a-447a-bdf1-d25d233c4454"), 9, "Set de bolígrafos de gel de colores vivos y tinta de secado rápido, perfectos para tomar notas y hacer dibujos creativos. Desata tu creatividad con este conjunto de bolígrafos que ofrecen una escritura suave y vibrante. Con una variedad de colores brillantes, puedes añadir un toque de color a tus notas, dibujos y proyectos artísticos. Además, la tinta de secado rápido evita manchas y borrones, garantizando resultados impecables. Ya sea en la escuela, el trabajo o en casa, estos bolígrafos son la elección ideal para expresarte de forma creativa y hacer que tus ideas cobren vida.", "https://th.bing.com/th/id/R.fbee547f59ddd79676e87d29bcde5881?rik=ycY9mXzLL9d9BA&pid=ImgRaw&r=0", "Bolígrafos de Gel de Colores", 12999m },
                    { new Guid("1d55b9cc-c986-4def-b4b5-75ff9ca603c6"), 6, "Mochila de senderismo con capacidad de 40 litros y sistema de ventilación. Prepárate para tus aventuras al aire libre con esta mochila espaciosa y funcional. Su diseño ergonómico y sistema de ventilación mantienen tu espalda fresca y cómoda durante largas caminatas. Con múltiples compartimentos y correas ajustables, te ofrece organización y comodidad para llevar todo lo necesario. ¡Explora la naturaleza con estilo y confort!", "https://th.bing.com/th/id/R.4eabdbb111407617031f2905e992ae2a?rik=hrWxgNU%2f6uUHBQ&pid=ImgRaw&r=0", "Mochila de Senderismo Quechua", 130000m },
                    { new Guid("1e855804-2e6e-4b26-b12a-068f71fabd1d"), 6, "Pelota oficial de la NBA fabricada con materiales de alta calidad para un rendimiento óptimo. Vive la emoción del baloncesto con esta pelota oficial utilizada en los mejores torneos. Fabricada con materiales premium, ofrece un agarre excepcional y una respuesta precisa en cada dribbling, pase y tiro. Ya sea en la cancha o en tu patio trasero, esta pelota te permite disfrutar del juego con la autenticidad y calidad que esperas de la NBA.", "https://th.bing.com/th/id/OIP.aSw6EBUAKtHSRi3w8ZVL2AHaHa?rs=1&pid=ImgDetMain", "Pelota de Baloncesto Spalding NBA", 55794m },
                    { new Guid("20b29415-e5ea-4b09-9daa-bca4048fdcdd"), 4, "Sartén antiadherente de titanio con mango ergonómico y revestimiento resistente a rayones, ideal para cocinar sin que los alimentos se peguen. Con esta sartén, disfruta de una cocina más saludable y fácil. El revestimiento antiadherente de titanio garantiza una cocción uniforme y sin problemas, mientras que el mango ergonómico proporciona un agarre cómodo y seguro. Además, su revestimiento resistente a rayones asegura una durabilidad excepcional. Cocina con facilidad y disfruta de resultados perfectos en cada comida.", "https://topsartenes.com/wp-content/uploads/2018/08/Tefal-Emotion-Sart%C3%A9n-de-Aluminio-de-20-cm-Antiadherente-Titanium-Extra-1024x482.jpg", "Sartén Antiadherente de Titanio", 73999m },
                    { new Guid("21b246c7-3a89-4827-80e9-ce155c5db27b"), 5, "Cepillo eléctrico recargable con tecnología de limpieza avanzada para una salud bucal óptima. Mejora tu rutina de cuidado bucal con este cepillo eléctrico que ofrece una limpieza superior. Con tecnología de limpieza avanzada, elimina más placa que un cepillo manual, manteniendo tus dientes y encías saludables. El diseño recargable y ergonómico lo hace fácil y cómodo de usar. Descubre una sonrisa más brillante y una boca más saludable con este cepillo eléctrico de calidad.", "https://th.bing.com/th/id/OIP.FO98Jv9ZUgYGZupqbByo-gHaHa?rs=1&pid=ImgDetMain", "Cepillo Eléctrico Colgate", 25666m },
                    { new Guid("227d8498-7556-4104-b948-1cbf46abbc8a"), 2, "Monitor gaming de alta velocidad de actualización y resolución 4K para una experiencia de juego inmersiva. Sumérgete en el mundo del gaming con este monitor que ofrece lo último en rendimiento visual. Con una alta velocidad de actualización, cada movimiento es fluido y sin desenfoques, mientras que la resolución 4K brinda imágenes nítidas y detalladas. Ya sea que estés compitiendo en juegos de acción rápida o explorando mundos virtuales, este monitor te ofrece una experiencia de juego envolvente y emocionante.", "https://www.allround-pc.com/wp-content/uploads/2017/02/Asus-ROG-PG258Q-Frontansicht.jpg", "Monitor Gaming ASUS ROG Swift", 699999m },
                    { new Guid("25cbf1de-cf05-4f7f-9655-9b073cbbe6e0"), 4, "Bolsa de viaje resistente al agua con múltiples compartimentos y correa ajustable, ideal para viajes cortos o escapadas de fin de semana. Prepárate para tus aventuras con esta bolsa versátil que combina funcionalidad y estilo. Su diseño resistente al agua protege tus pertenencias de la lluvia y la humedad, mientras que los múltiples compartimentos te permiten organizar tus cosas de manera eficiente. Con una correa ajustable, puedes llevarla cómodamente sobre el hombro o cruzada. Ya sea para una escapada de fin de semana o un viaje corto, esta bolsa es el compañero perfecto para tus desplazamientos.", "https://th.bing.com/th/id/OIP.M1clNbkMiqw3Qlm7w1FstAHaHa?rs=1&pid=ImgDetMain", "Bolsa de Viaje Resistente al Agua", 25000m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("262ee62c-990c-4bd6-bcee-764c54a0ddc7"), 4, "Silla de oficina ergonómica con respaldo ajustable y soporte lumbar, diseñada para proporcionar comodidad durante largas horas de trabajo. Optimiza tu espacio de trabajo con esta silla diseñada pensando en tu comodidad y bienestar. Su respaldo ajustable y soporte lumbar te permiten encontrar la posición perfecta para mantener una postura saludable durante todo el día. Además, su diseño ergonómico reduce la fatiga y el malestar, permitiéndote concentrarte en tus tareas con mayor eficiencia. Ya sea en la oficina o en casa, esta silla es la compañera ideal para afrontar jornadas laborales prolongadas con confort y estilo.", 10, "https://th.bing.com/th/id/R.ae0f38a9f4e01157bf8c01741e09b469?rik=Efl%2fqCQ9eMdfOw&pid=ImgRaw&r=0", "Silla de Oficina Ergonómica", 199999m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("27840ba1-e7f8-42de-81ff-010ab69c4c27"), 4, "Silla de oficina ergonómica con soporte lumbar ajustable y reposabrazos acolchados. Prioriza tu comodidad y salud en el trabajo con esta silla diseñada para ofrecer el máximo confort. El soporte lumbar ajustable se adapta a tu espalda para una postura óptima, mientras que los reposabrazos acolchados brindan apoyo y alivio durante largas horas de trabajo. Con un diseño ergonómico y materiales de alta calidad, esta silla mejora tu bienestar y productividad en el entorno laboral.", "https://m.media-amazon.com/images/I/71yUHcOanKL._AC_SL1500_.jpg", "Butaca de Oficina Ergonómica ", 189999m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("343a5af6-a23b-4f12-9bef-4573c5ecc0a4"), 6, "Silla plegable de playa con respaldo reclinable y reposabrazos. Disfruta del máximo confort en la playa con esta silla versátil. Su diseño plegable la hace fácil de transportar y almacenar, mientras que el respaldo reclinable y los reposabrazos ofrecen una posición personalizada para relajarte. Construida con materiales resistentes, es perfecta para largas jornadas bajo el sol. Prepárate para tus días de playa con estilo y comodidad.", 10, "https://images-na.ssl-images-amazon.com/images/I/71pw6mc4GFL._AC_SL1500_.jpg", "Silla de Playa Plegable", 42530m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("3674b5f7-a881-43e8-a2e6-8c3f1421024f"), 5, "Kit de maquillaje de labios con una variedad de colores y acabados, incluye barras de labios líquidas y labiales en barra. Explora un mundo de opciones de maquillaje para tus labios con este completo kit. Desde tonos vibrantes hasta sutiles acabados mate, encontrarás el color perfecto para cada ocasión. Las barras de labios líquidas ofrecen una aplicación suave y de larga duración, mientras que los labiales en barra proporcionan un acabado cremoso y confortable. Añade un toque de color y estilo a tu look diario con este versátil kit de maquillaje de labios.", "https://th.bing.com/th/id/OIP.T9jtfnpiu8aLb93zXZx02gHaFj?rs=1&pid=ImgDetMain", "Kit de Maquillaje de Labios", 11999m },
                    { new Guid("38384a7d-c21b-4d38-be78-0f44a3b06faa"), 10, "Taladro inalámbrico con batería de larga duración y múltiples funciones para proyectos de bricolaje. Haz realidad tus proyectos con este taladro versátil que ofrece potencia y libertad de movimiento. Equipado con una batería de larga duración, te permite trabajar sin interrupciones durante más tiempo. Además, su diseño compacto y ergonómico facilita su manejo en espacios reducidos. Ya sea para perforar, atornillar o taladrar, este taladro inalámbrico es la herramienta perfecta para tus proyectos de bricolaje en casa o en el trabajo.", "https://plazavea.vteximg.com.br/arquivos/ids/1512004-1000-1000/image-af25755c17524609b15a734685f3195f.jpg?v=637547892553400000", "Taladro Inalámbrico Bosch", 198243m },
                    { new Guid("3957cfeb-4638-4cac-b3ca-88238ea7867f"), 5, "Cepillo de dientes eléctrico recargable con tecnología de detección de posición y temporizador. Optimiza tu rutina de higiene bucal con este cepillo avanzado que garantiza una limpieza efectiva. La tecnología de detección de posición te guía para asegurar una cobertura completa de tus dientes y encías, mientras que el temporizador te indica cuándo cambiar de área. Con cerdas de alta calidad y una batería recargable, es la elección ideal para una sonrisa saludable y radiante.", "https://res.cloudinary.com/walmart-labs/image/upload/w_960,dpr_auto,f_auto,q_auto:best/gr/images/product-images/img_large/00421020182661L.jpg", "Cepillo Eléctrico Oral-B", 35567m },
                    { new Guid("399de127-3bd0-47c4-ad54-a9e30464514b"), 1, "Set de cucharas medidoras de cocina en diferentes tamaños, perfecto para medir ingredientes con precisión al cocinar. Simplifica tus preparaciones culinarias con este práctico set de cucharas medidoras. Con una variedad de tamaños, desde cucharaditas hasta cucharadas, te permite medir con precisión cada ingrediente según las indicaciones de tus recetas. Fabricadas con materiales duraderos y fáciles de limpiar, estas cucharas son indispensables en cualquier cocina. Ya sea que estés horneando, cocinando o preparando bebidas, este set te garantiza resultados perfectos en cada ocasión.", "https://th.bing.com/th/id/OIP.YnBwconuCDmzHmHqnv6SAwHaHa?rs=1&pid=ImgDetMain", "Set de Cucharas Medidoras", 6999m },
                    { new Guid("3a207540-ae38-4ef7-9bf6-b9744035e782"), 9, "Cuaderno de notas de cuero genuino con papel de alta calidad, perfecto para tomar apuntes o dibujar. Eleva tu experiencia de escritura con este elegante cuaderno elaborado con cuero genuino y papel de primera calidad. Ya sea para anotar tus ideas, reflexiones o bocetos, cada página ofrece una superficie suave y resistente para plasmar tus pensamientos. Con un diseño duradero y sofisticado, es el compañero ideal para tu vida diaria, ya sea en el trabajo, la escuela o tus momentos creativos.", "https://th.bing.com/th/id/R.293baa69fe461d6e8c3f6046a511e51e?rik=pCpCqu75TTSwJQ&pid=ImgRaw&r=0", "Cuaderno de Notas de Cuero", 15000m },
                    { new Guid("3c246a0d-c658-41dc-adaf-38daf9c8408b"), 4, "Prepara tus comidas con facilidad con este juego de sartenes de cerámica antiadherente. Incluye 3 tamaños diferentes para adaptarse a tus necesidades culinarias. La superficie antiadherente garantiza una cocción sin problemas y una fácil limpieza. Con un diseño resistente y duradero, son ideales para cocinar de manera saludable y sabrosa en cualquier cocina.", "https://images-na.ssl-images-amazon.com/images/I/61cpkKCW2zL._AC_SX569_.jpg", "Set de Sartenes Cerámica T-fal", 110999m },
                    { new Guid("3cda7c98-905d-4e42-bed9-5acabcee64e9"), 8, "Cerveza artesanal IPA de 330 ml, pack de 6 unidades. Disfruta del sabor único y la frescura de esta cerveza de calidad premium. Con un equilibrio perfecto entre lúpulos aromáticos y maltas, cada sorbo es una experiencia para los amantes de la cerveza. Ideal para compartir con amigos o para disfrutar en cualquier ocasión.", "https://th.bing.com/th/id/OIP.zOU4uKEJEthoqpsCgNd5PQHaLC?w=725&h=1080&rs=1&pid=ImgDetMain", "Cerveza Artesanal IPA", 6000m },
                    { new Guid("3de32f0e-d96c-4fbb-8c4d-64a27251a0c4"), 8, "Pack variado de cervezas artesanales seleccionadas de diferentes estilos y sabores. Descubre una experiencia única de degustación con este pack que ofrece una variedad de cervezas artesanales cuidadosamente seleccionadas. Desde ales robustas hasta lagers refrescantes, cada botella te lleva en un viaje de sabores y estilos. Perfecto para compartir con amigos o disfrutar en solitario, este pack es una invitación a explorar el mundo diverso y emocionante de la cerveza artesanal.", "https://naciontequila.com/wp-content/uploads/2021/03/Six_Pack_Cerveza_Artesanal_Wendlandt.jpeg", "Cerveza Artesanal Pack Variado", 10999m },
                    { new Guid("3e8a0bc3-9550-4006-8a0b-e39766080b39"), 4, "Set de velas aromáticas con fragancias naturales para crear un ambiente relajante en tu hogar. Transforma tu espacio en un oasis de serenidad con este encantador set de velas. Cada vela está cuidadosamente elaborada con fragancias naturales que llenan la habitación con aromas reconfortantes y relajantes. Ya sea para una noche tranquila en casa o para una sesión de meditación, este set te ayudará a crear el ambiente perfecto para relajarte y rejuvenecer cuerpo y mente.", "https://velasarcanjo.com.br/wp-content/uploads/2022/01/PRF260-2.webp", "Set de Velas Aromáticas", 15955m },
                    { new Guid("41704623-87de-4407-8eac-4064d0ba1f5e"), 6, "Bicicleta de montaña con cuadro de aluminio y suspensión delantera, ideal para aventuras en terrenos accidentados. Conquista los senderos más desafiantes con esta bicicleta diseñada para el rendimiento y la durabilidad. El cuadro de aluminio garantiza ligereza y resistencia, mientras que la suspensión delantera absorbe los golpes en terrenos irregulares. Ya sea en montañas, bosques o caminos escarpados, esta bicicleta te ofrece control y comodidad para disfrutar al máximo de tus aventuras al aire libre.", "https://th.bing.com/th/id/OIP.tp3k62QfNs3RC6VGbgMK9QHaHa?rs=1&pid=ImgDetMain", "Bicicleta de Montaña", 350444m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("419c9ffc-e026-4676-a897-d971656d62b6"), 2, "Descubre un mundo de entretenimiento en alta definición con este televisor LED de 55 pulgadas. Su impresionante resolución 4K y la tecnología HDR te sumergen en imágenes vívidas y detalladas, creando una experiencia visual cautivadora que redefine tu forma de ver televisión. Disfruta de colores vibrantes, contrastes intensos y una claridad excepcional en cada escena, haciendo que cada momento cobre vida con una nitidez asombrosa. Con este televisor, cada película, serie o evento deportivo se convierte en una experiencia inmersiva que te transporta directamente al corazón de la acción.", 20, "https://images.samsung.com/is/image/samsung/es-uhd-ku6000-ue55ku6000kxxc-008-side-black?$L2-Thumbnail$", "Samsung Smart TV 55 pulgadas", 735000m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("42f56ba5-359e-4ba9-811c-70bc2742bb54"), 3, "Reloj de pulsera resistente al agua con cronómetro y calendario, diseño clásico y duradero. Mantén el tiempo con estilo y funcionalidad con este reloj que combina elegancia y rendimiento. Su resistencia al agua te permite llevarlo en cualquier actividad, mientras que el cronómetro y calendario agregan utilidad adicional. Con un diseño clásico y duradero, este reloj es el complemento perfecto para cualquier ocasión, ya sea en el trabajo, en el gimnasio o en tus aventuras al aire libre.", "https://m.media-amazon.com/images/I/71oE44fIffL._AC_UL1500_.jpg", "Reloj de Pulsera Casio", 84899m },
                    { new Guid("48d32305-6cff-4c62-a671-8e6738820fb1"), 8, "Botella de vino tinto reserva, añada 2017, Denominación de Origen Rioja. Disfruta de la excelencia enológica con este vino tinto reserva cuidadosamente elaborado. Con una añada excepcional, ofrece aromas complejos y sabores intensos que deleitarán tu paladar. Proveniente de la prestigiosa región de Rioja, garantiza calidad y tradición en cada sorbo. Eleva tus momentos especiales con este vino de distinción.", "https://th.bing.com/th/id/OIP.AUrvOxdlC6KV6wTmbIk0qgHaOj?rs=1&pid=ImgDetMain", "Vino Tinto Reserva Marqués de Cáceres", 35999m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("4c9269a9-f365-4b18-b8d7-b090f6256873"), 1, "Acondicionador de aire portátil con control remoto y temporizador, adecuado para espacios pequeños y medianos. Mantén tu hogar fresco y confortable con este práctico acondicionador de aire. Con su diseño portátil, puedes llevarlo fácilmente a cualquier habitación que necesite refrigeración. El control remoto y el temporizador te permiten ajustar la temperatura y programar el funcionamiento según tus preferencias. Ideal para espacios pequeños y medianos, este acondicionador de aire ofrece una solución eficaz para combatir el calor durante los meses más calurosos del año.", 20, "https://images.deprati.com.ec/sys-master/images/hf8/h01/9954234073118/14224384-0_product_1200Wx1800H", "Acondicionador de Aire Portátil", 483867m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("4daf3a3d-e348-4321-baf0-c057fec44ffb"), 1, "Batidora de mano con múltiples velocidades y accesorios intercambiables para preparar una variedad de recetas", "https://th.bing.com/th/id/OIP.qITwgFqkKuINs7ghNPPAKgHaHa?rs=1&pid=ImgDetMain", "Batidora de Mano KitchenAid", 29899m },
                    { new Guid("4fd1e89a-9954-4c3d-a9e1-664a61ae0c45"), 7, "Set de bloques de construcción magnéticos para niños, fomenta la creatividad y la habilidad motora. Despierta la imaginación de tus hijos con este set de bloques magnéticos que les permite crear estructuras infinitas. La combinación de colores vibrantes y piezas magnéticas ofrece oportunidades ilimitadas para construir y experimentar. Además de divertirse, los niños desarrollan habilidades motoras finas y aprenden conceptos de ciencia y geometría de manera intuitiva. ¡Explora el mundo de la construcción de manera creativa y educativa con este emocionante set de bloques magnéticos!", "https://th.bing.com/th/id/OIP.P61m2Pr3M_iWDUunq2wJgwHaHT?rs=1&pid=ImgDetMain", "Set de Bloques de Construcción Magnéticos", 45999m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("50dddc9b-f6a7-4cc5-abcb-510673b6a3ca"), 6, "Monitor de actividad física con seguimiento de pasos, distancia, calorías quemadas y monitorización del sueño, ideal para mantener un estilo de vida saludable. Mantén un registro detallado de tu actividad diaria con este monitor que te ayuda a alcanzar tus objetivos de bienestar. Registra tus pasos, la distancia recorrida y las calorías quemadas para mantenerte en movimiento. Además, monitoriza la calidad de tu sueño para asegurar un descanso reparador. Con su diseño ergonómico y funciones avanzadas, este monitor es tu compañero perfecto para alcanzar un estilo de vida más saludable y activo.", 5, "https://th.bing.com/th/id/OIP.6uxVrzkzA4v387JSzflFygHaHN?rs=1&pid=ImgDetMain", "Monitor de Actividad Física", 270669m },
                    { new Guid("54b0571c-604a-4ab6-9dac-23b322a16a72"), 10, "Maletín ejecutivo de cuero genuino con compartimento acolchado para portátil. Lleva tu estilo y tus dispositivos con elegancia y seguridad. El cuero genuino proporciona durabilidad y un aspecto profesional, mientras que el compartimento acolchado protege tu portátil de golpes y arañazos. Con múltiples bolsillos y un diseño práctico, este maletín es ideal para profesionales en movimiento que valoran la calidad y el estilo.", 15, "https://www.losroblespolotime.com/wp-content/uploads/2018/02/maletines-de-cuero-hombre-ejecutivos1206r-1080x1080.jpg", "Maletín de Cuero para Portátil", 98043m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("580d9d59-cded-47d1-8903-2c1c31b6e8f9"), 4, "Juego de cuchillos de chef profesionales con hojas de acero inoxidable y mangos ergonómicos, perfectos para cortar y picar con precisión. Equipa tu cocina con este juego de cuchillos de alta calidad que hacen que la preparación de alimentos sea más fácil y precisa. Las hojas de acero inoxidable mantienen su filo durante más tiempo y ofrecen un corte limpio y preciso. Los mangos ergonómicos proporcionan un agarre cómodo y seguro, reduciendo la fatiga durante el uso prolongado. Ya seas un chef profesional o un entusiasta de la cocina en casa, este juego de cuchillos es imprescindible para tu colección de utensilios de cocina.", "https://img-static.insania.com/imagens/50000/5875/04.jpg", "Juego de Cuchillos de Chef", 37555m },
                    { new Guid("5b0d45f8-dd3a-4b1b-a5d8-87271bfc6823"), 2, "Cámara de acción resistente al agua con grabación en 4K, completa con accesorios. Captura tus aventuras en alta definición y sin preocupaciones gracias a su resistencia al agua. Con calidad de imagen excepcional y una variedad de accesorios incluidos, como soportes y correas, estarás listo para cualquier desafío. Registra cada momento emocionante con claridad y detalle asombrosos.", "https://netpc.uy/wp-content/uploads/2021/03/1-219-1024x1024.jpg", "Cámara de Acción GoPro HERO9", 822999m },
                    { new Guid("5c110ea2-0f3c-4b5b-87a8-714da8f112d7"), 4, "Lámpara de escritorio LED con regulación de intensidad y brazo ajustable, perfecta para estudio o trabajo. Ilumina tu espacio de trabajo con esta lámpara que combina funcionalidad y estilo. Con tecnología LED, ofrece una iluminación brillante y de bajo consumo energético. La regulación de intensidad te permite ajustar la luz según tus necesidades, mientras que el brazo ajustable te proporciona flexibilidad para dirigir la luz hacia donde la necesites. Ya sea para estudiar, trabajar o leer, esta lámpara de escritorio te ofrece la iluminación perfecta para maximizar tu productividad y comodidad.", "https://image.biccamera.com/img/00000010204497_A03.jpg?sr.dw=600&sr.jqh=60&sr.dh=600&sr.mat=1", "Lámpara de Escritorio LED", 19027m },
                    { new Guid("5efaedbc-4ed8-4ad9-9d70-78f5d78945e2"), 4, "Lámpara de pie LED con regulador de intensidad y diseño moderno. Ilumina tu espacio con estilo y funcionalidad gracias a su tecnología LED de bajo consumo y su regulador de intensidad. Su diseño moderno complementa cualquier decoración, mientras que su luz ajustable crea el ambiente perfecto para cada ocasión. Añade un toque de elegancia y practicidad a tu hogar.", "https://lw-cdn.com/images/A8D7BA23AD52/k_6d8b4629109401923e80ac17b79198d2;w_1600;h_1600;q_100/lampara-de-pie-led-oficina-somidia-dimmer-blanco.jpg", "Lámpara de Pie LED", 16999m },
                    { new Guid("63cdb155-9ce0-43a8-874c-49a9ddfd393c"), 10, "Caja de herramientas de mano con destornilladores, llaves ajustables y otras herramientas esenciales para tareas de bricolaje y reparaciones en el hogar. Prepárate para cualquier proyecto con este completo conjunto de herramientas. Incluye destornilladores de diferentes tamaños y tipos, llaves ajustables, alicates y más, todo organizado en una práctica caja de almacenamiento. Ya sea que necesites apretar tornillos sueltos, colgar cuadros o realizar reparaciones menores, este conjunto te ofrece las herramientas necesarias para hacer el trabajo de manera eficiente y efectiva.", "https://m.media-amazon.com/images/I/71rpqADybwL._AC_SL1500_.jpg", "Caja de Herramientas de Mano", 49999m },
                    { new Guid("645fce02-2880-4744-9d77-506fce987200"), 9, "Kit de experimentos científicos para niños con actividades educativas y divertidas sobre física, química y biología. Despierta la curiosidad y el interés por la ciencia con este completo kit que ofrece una amplia variedad de experimentos. Desde la exploración de la electricidad y el magnetismo hasta la observación de reacciones químicas y la vida microscópica, cada actividad enseña conceptos fundamentales de manera entretenida. Perfecto para fomentar el aprendizaje interactivo en casa o en el aula, este kit brinda a los niños la oportunidad de explorar y descubrir el fascinante mundo que los rodea.", "https://a0.soysuper.com/f41014ea1c5d020390d2079b835b3f67.1024.0.0.0.wmark.8e20f03f.jpg", "Kit de Experimentos Científicos para Niños", 23898m },
                    { new Guid("68e40295-8188-4ae4-b3c3-4b3cc399e5b5"), 10, "Juego de destornilladores de precisión con puntas intercambiables y mango antideslizante, ideal para reparaciones delicadas. Haz frente a trabajos de precisión con confianza utilizando este completo juego de destornilladores. Sus puntas intercambiables te permiten adaptarte a una variedad de tamaños y tipos de tornillos, mientras que el mango antideslizante garantiza un agarre firme y cómodo durante el uso. Ya sea que estés reparando dispositivos electrónicos, juguetes o relojes, este juego de destornilladores es imprescindible para cualquier aficionado o profesional que requiera precisión y fiabilidad en sus trabajos.", "https://th.bing.com/th/id/OIP.8biKpp24on-_MKc-ICiqdwHaIS?rs=1&pid=ImgDetMain", "Juego de Destornilladores de Precisión", 5000m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("6d579f08-09bd-4351-9fa3-572d6fba8779"), 2, "Monitor de computadora LED de 24 pulgadas con resolución Full HD. Experimenta imágenes claras y nítidas en una pantalla de gran tamaño. Perfecto para trabajar, jugar o ver películas, este monitor ofrece una calidad de visualización excepcional. Con tecnología LED, garantiza colores vibrantes y un bajo consumo de energía. Mejora tu experiencia informática con este monitor de alto rendimiento.", 10, "https://c1.neweggimages.com/ProductImageCompressAll1280/24-009-642-02.jpg", "Monitor Acer Full HD 24", 443995m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("6f1d34e2-e4d2-4e10-9afc-f6f700871c4d"), 6, "Mochila de senderismo con capacidad de 40 litros y sistema de soporte ergonómico, ideal para excursiones al aire libre. Prepárate para tus aventuras al aire libre con esta mochila diseñada para ofrecer comodidad y funcionalidad. Con su amplia capacidad de 40 litros, puedes llevar todo lo necesario para tus excursiones. El sistema de soporte ergonómico distribuye el peso de manera uniforme, reduciendo la tensión en la espalda y los hombros. Con bolsillos y compartimentos organizativos, esta mochila te permite acceder fácilmente a tus pertenencias mientras exploras la naturaleza.", "https://th.bing.com/th/id/OIP.-U9RWQ9p2FVVS23uus1NOwHaHa?w=600&h=600&rs=1&pid=ImgDetMain", "Mochila de Senderismo", 124999m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("70292951-8fd7-42ba-a8c8-7fe64ed5b4df"), 6, "Bicicleta de montaña con cuadro de aluminio y suspensión delantera, ideal para aventuras off-road. Su construcción resistente y ligera ofrece un rendimiento óptimo en terrenos accidentados, mientras que la suspensión delantera absorbe los impactos para una conducción suave y controlada. ¡Explora nuevos caminos con confianza y comodidad!", 5, "https://content.bikeroar.com/system/product/000/100/748/large/GT-Bicycles_Aggressor-Disc-XS-26_white-red-blue-side_2015.jpg?1472295473", "Bicicleta GT Aggresso", 400000m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("70fc8e30-9de1-405d-9883-d1c8139cbbd4"), 2, "Altavoz Bluetooth portátil con sonido estéreo de alta calidad y batería de larga duración, perfecto para llevar la música a todas partes. Disfruta de una experiencia auditiva inigualable con este altavoz compacto y potente. Conecta tu dispositivo Bluetooth y disfruta de un sonido estéreo claro y envolvente dondequiera que vayas. Además, su batería de larga duración te permite disfrutar de horas de música sin interrupciones. Ya sea en casa, al aire libre o de viaje, este altavoz es tu compañero perfecto para disfrutar de tu música favorita.", "https://topesdegama.com/app/uploads-topesdegama.com/2019/08/Altavoz-Bluetooth-1-2.jpg", "Altavoz Bluetooth Portátil", 26000m },
                    { new Guid("7354a0f1-aaa1-477d-b4b7-81cc5107f99e"), 5, "Máscara facial de arcilla purificante para una piel limpia y radiante, adecuada para todo tipo de piel. Renueva tu piel con esta máscara facial que ofrece una limpieza profunda y una sensación de frescura. Formulada con arcilla purificante, ayuda a eliminar impurezas, absorber el exceso de grasa y reducir los poros. Adecuada para todo tipo de piel, esta máscara deja la piel limpia, suave y radiante. Disfruta de una experiencia de spa en casa y revela una tez revitalizada con esta máscara facial rejuvenecedora.", "https://i.etsystatic.com/28794076/r/il/1a4dba/3039512871/il_fullxfull.3039512871_4c6l.jpg", "Máscara Facial de Arcilla", 5999m },
                    { new Guid("74a84ac5-ae6b-481b-b5b0-cf72c2151e85"), 5, "Kit de cuidado de barba que incluye aceite, bálsamo, peine y tijeras, ideal para mantener la barba suave y bien cuidada. Haz que tu barba luzca impecable con este completo kit de cuidado. El aceite y el bálsamo nutren e hidratan la barba, manteniéndola suave y con un aspecto saludable. El peine y las tijeras te permiten dar forma y estilizar tu barba con precisión. Ya sea que tengas una barba corta o larga, este kit es esencial para mantenerla en óptimas condiciones y lucir siempre impecable.", "https://images-na.ssl-images-amazon.com/images/I/91X5mdnG9%2BL._SL1500_.jpg", "Kit de Cuidado de Barba", 22799m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("760fa88c-fb39-455d-a5e8-74a929f950e0"), 6, "Bicicleta estática de ejercicio con monitor LCD y resistencia ajustable, ideal para entrenamiento cardiovascular en casa. Con esta bicicleta, puedes mejorar tu salud cardiovascular cómodamente desde casa. El monitor LCD te proporciona datos en tiempo real sobre tu tiempo, distancia, velocidad y calorías quemadas, mientras que la resistencia ajustable te permite personalizar tu entrenamiento. Compacta y fácil de usar, es perfecta para personas de todas las edades y niveles de condición física que deseen mantenerse en forma y saludables.", 10, "https://contents.mediadecathlon.com/p1010256/k$081a10060ffdea37ce7c96e4808c8c43/sq/Bicicleta+Est+tica+Iniciaci+n+Domyos+Essential.jpg", "Bicicleta Estática de Ejercicio", 181175m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("78eae903-9c7b-450c-91a2-c89247d5a6ba"), 5, "Pistola de masaje muscular con múltiples cabezales intercambiables y ajuste de velocidad, ideal para recuperación después del ejercicio. Acelera tu proceso de recuperación muscular con esta pistola de masaje que ofrece una terapia de percusión efectiva. Equipada con varios cabezales intercambiables, puedes personalizar tu experiencia de masaje según tus necesidades específicas. El ajuste de velocidad te permite controlar la intensidad del masaje, mientras que su diseño ergonómico garantiza un uso cómodo y preciso. Ya sea para aliviar la tensión muscular, mejorar la circulación o reducir el tiempo de recuperación, esta pistola de masaje es tu compañero ideal después del ejercicio.", "https://s.libertaddigital.com/2021/05/04/pistola-de-masaje-muscular-hoposo-jmq.jpg", "Pistola de Masaje Muscular", 43444m },
                    { new Guid("7c34547e-061b-485d-bacf-f66ae24e2ab2"), 4, "Funda nórdica de algodón percal, tamaño queen, incluye fundas de almohada. Renueva tu dormitorio con esta funda nórdica de calidad premium. Fabricada con algodón percal, ofrece suavidad y frescura para un descanso reparador. El tamaño queen proporciona una cobertura generosa, mientras que las fundas de almohada a juego completan el conjunto. Dale un toque de estilo y confort a tu cama con esta funda nórdica elegante y funcional.", "https://th.bing.com/th/id/R.20eeebe126d017ce8fa1c815dbaf35eb?rik=mqliLGuUG0eP7Q&pid=ImgRaw&r=0", "Funda Nórdica Algodón Percal", 7550m },
                    { new Guid("7c4c764c-a072-4810-8d3c-e1e5ca87c047"), 2, "Smartphone con pantalla AMOLED de 6.6 pulgadas, cámara de 108 MP y 5G. Experimenta la potencia y la innovación en la palma de tu mano con este smartphone de última generación. La pantalla AMOLED ofrece colores vibrantes y detalles nítidos, mientras que la cámara de 108 MP captura imágenes increíbles con claridad y precisión. Con conectividad 5G, disfruta de velocidades ultrarrápidas para navegar, transmitir y jugar sin problemas. Descubre un nuevo nivel de rendimiento y tecnología con este smartphone avanzado.", "https://www.whatsmobiles.com/wp-content/uploads/2022/01/samsung-galaxy-s22-ultra.jpg", "Smartphone Samsung Galaxy S22", 970423m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("7e08b7c6-da72-4803-b3b1-e2a86068f3fd"), 5, "Plancha de pelo con placas de cerámica y ajuste de temperatura, perfecta para alisar o rizar el cabello de forma segura. Obtén resultados profesionales en la comodidad de tu hogar con esta plancha de pelo de alta calidad. Sus placas de cerámica proporcionan un calor uniforme que protege tu cabello del daño por calor, mientras que el ajuste de temperatura te permite adaptarla a tu tipo de cabello. Ya sea que desees un cabello liso y sedoso o unos rizos sueltos y definidos, esta plancha es tu aliada para lograr el estilo que desees de manera segura y eficiente.", 6, "https://www.joopzy.com/wp-content/uploads/2017/12/primary-1.jpg", "Plancha de Pelo Cerámica", 22499m },
                    { new Guid("7e562178-53cb-4540-b899-afee18c5db36"), 3, "Deslumbra en cualquier ocasión con este elegante vestido de fiesta. Con un favorecedor escote en V y un delicado detalle de encaje, es perfecto para destacar tu estilo y elegancia. Su diseño atemporal y sofisticado lo convierte en una elección ideal para eventos especiales. ¡Brilla con confianza y glamour en cada paso!", 10, "https://cdn0.matrimonio.com.co/articles/images/dress/1/0/6/6/t30_m186601.jpg", "Vestido de Fiesta Elegante", 35000m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("7ef65253-76e4-4aaa-a01d-479b2efc6c9c"), 5, "Kit de maquillaje completo para principiantes que incluye productos básicos como base, corrector, sombras y labiales. Con este kit, puedes experimentar y crear looks increíbles fácilmente. Desde una base uniforme hasta unos labios llamativos, todo lo que necesitas está al alcance de tu mano. Perfecto para aprender y explorar el mundo del maquillaje, este kit te ayuda a resaltar tu belleza natural y expresar tu estilo único.", "https://d3fa68hw0m2vcc.cloudfront.net/900/171450335.jpeg", "Kit de Maquillaje para Principiantes", 19898m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("802ffd8d-12c2-4426-9c97-186d3d53d462"), 3, "Pantalones vaqueros de corte recto y lavado oscuro, tallas disponibles: 28 .Estilo clásico y versátil para tu guardarropa.Confeccionados con denim de alta calidad, estos pantalones ofrecen comodidad y durabilidad.El corte recto proporciona un ajuste favorecedor, mientras que el lavado oscuro añade un toque de sofisticación.Completa tu look con estos pantalones que combinan con cualquier ocasión.", 20, "https://th.bing.com/th/id/OIP.IAnlOIP1QdYyXurUpvfjgAHaJ3?rs=1&pid=ImgDetMain", "Jeans Levi's 501", 29000m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("80b6ba25-1e43-48a8-bd7e-5eda0911bc83"), 6, "Set completo de palos de golf con bolsa de transporte, ideal para principiantes y jugadores intermedios. Prepárate para el campo de golf con este set que ofrece todo lo necesario para comenzar a jugar. Con una variedad de palos diseñados para diferentes situaciones en el campo, este set te ayuda a mejorar tu juego. La bolsa de transporte facilita el transporte de tus palos y accesorios. Ya sea que estés dando tus primeros pasos en el golf o buscando mejorar tu habilidad, este set es la elección perfecta para tu próxima partida.", "https://th.bing.com/th/id/R.baf0809a66e9feb6bd7448f9cd920e5c?rik=yuY7pmx3%2feSbFA&pid=ImgRaw&r=0", "Set de Golf Completo", 871200m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("87db9f69-f101-4c88-b45c-dccae66c1917"), 7, "Juego de mesa de estrategia que desafía tu mente y habilidades estratégicas, perfecto para partidas emocionantes con amigos o familiares. Sumérgete en la emoción y el desafío de este juego que pondrá a prueba tus capacidades de planificación y táctica. Con reglas simples pero profundas, ofrece horas de diversión competitiva para jugadores de todas las edades. Desde movimientos calculados hasta decisiones estratégicas, cada partida es una oportunidad para mejorar tus habilidades y superar a tus oponentes. Reúne a tus seres queridos y prepárate para emocionantes encuentros llenos de intriga y suspense con este juego de mesa que garantiza diversión sin fin.", 5, "https://th.bing.com/th/id/OIP.TYIWsTfGwGGq6vtdCUT7kwHaHa?rs=1&pid=ImgDetMain", "Juego de Mesa de Estrategia Battleship", 11000m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("880fa9c2-fa0c-4517-a5b8-269a48720d8e"), 6, "Este reloj inteligente es tu compañero perfecto para el fitness. Con monitor de ritmo cardíaco y GPS integrado, te ayuda a optimizar tu entrenamiento y a rastrear tus actividades con precisión. Además, su diseño elegante y funcional lo convierte en un accesorio imprescindible para tu estilo de vida activo.", "https://powermetercity.com/wp-content/uploads/2019/05/Garmin-Forerunner-245-GPS-Running-Smartwatch-Slate-Gray-3.png", "Smartwatch Garmin Forerunner 245", 350000m },
                    { new Guid("88961a0b-71eb-4d3a-8095-9c04f5d7b265"), 10, "Set completo de herramientas de jardinería, incluye pala, rastrillo, tijeras de podar, etc. Equípate para tus proyectos al aire libre con este conjunto de herramientas diseñado para jardineros de todos los niveles. Con una pala resistente, un rastrillo para limpiar y nivelar, tijeras de podar para dar forma a tus plantas y más, tienes todo lo necesario para cuidar y embellecer tu jardín. Simplifica tu trabajo en el jardín y disfruta de un espacio verde exuberante con este completo set de herramientas.", "https://m.media-amazon.com/images/I/611BfOCXEeL._AC_SL1500_.jpg", "Set de Herramientas de Jardinería", 39979m },
                    { new Guid("8d54b916-126d-49b1-907a-d29082d33402"), 7, "Tablero de ajedrez de madera de alta calidad, ideal para partidas en casa o en torneos. Disfruta del noble juego del ajedrez con este tablero meticulosamente elaborado. Fabricado con madera duradera, ofrece una superficie lisa y resistente para tus partidas. Su diseño clásico y elegante lo convierte en una pieza destacada en cualquier ambiente. Ya sea para practicar estrategias en casa o competir en torneos, este tablero garantiza una experiencia de juego excepcional.", "https://images-na.ssl-images-amazon.com/images/I/81q-sAnjp9L._AC_SL1500_.jpg", "Tablero de Ajedrez de Madera", 15606m },
                    { new Guid("9067edca-611e-41f2-96e9-99a87e20dcd7"), 2, "Auriculares inalámbricos con cancelación de ruido adaptativa y calidad de sonido premium. Sumérgete en tu música con estos auriculares que ofrecen una experiencia auditiva excepcional. La cancelación de ruido adaptativa bloquea eficazmente los sonidos externos, permitiéndote disfrutar de tu música sin distracciones. Con una calidad de sonido premium, cada nota se reproduce con claridad y precisión, brindándote una experiencia de audio inigualable. Disfruta de la libertad inalámbrica y el rendimiento de audio superior con estos auriculares de alta gama.", "https://plazavea.vteximg.com.br/arquivos/ids/648142-1000-1000/image-21437c9a137e44e1ae8aa15f27b82528.jpg?v=637448075451400000", "Auriculares Inalámbricos Sony WH-1000XM4", 319999m },
                    { new Guid("940d71b9-4bec-4cca-b1af-891daab118e9"), 10, "Set de herramientas de jardinería para niños con rastrillo, pala y regadera, perfecto para actividades al aire libre. Inspira a los pequeños jardineros con este set diseñado especialmente para ellos. Con un rastrillo, una pala y una regadera, los niños pueden explorar y aprender sobre el mundo natural mientras se divierten al aire libre. Este set les brinda la oportunidad de participar en actividades de jardinería de manera segura y educativa, fomentando su amor por la naturaleza y el cuidado del medio ambiente desde una edad temprana.", "https://th.bing.com/th/id/OIP.lvDnEJ1bsRI0qh5F2SskmAHaHa?rs=1&pid=ImgDetMain", "Herramientas de Jardinería para Niños", 23888m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("956c94f4-12ad-4f23-9874-f9bc533f50b0"), 1, "Secadora de ropa con capacidad de 7.4 pies cúbicos y tecnología de secado rápido. Simplifica tu rutina de lavandería con esta secadora de alta capacidad. Su tecnología de secado rápido te permite tener tu ropa lista en menos tiempo, ahorrando energía y tiempo. Con una capacidad de 7.4 pies cúbicos, es ideal para familias numerosas. Mantén tu ropa fresca y lista para usar con esta secadora eficiente y de alto rendimiento.", 15, "https://crecos.vteximg.com.br/arquivos/ids/182675-1000-1000/Lavadora-Secadora-Electrica-LG-WD11VVC3S6C-10-5-y-7-Kg-Carga-Frontal-DirectDrive-Inverter-Color-Acero_4.jpg?v=637291339645400000", "Secadora de Ropa LG", 999999m },
                    { new Guid("969968f9-2de3-4e3f-be4c-1e9378cb9381"), 10, "Caja de herramientas eléctricas que incluye taladro, sierra circular y otras herramientas esenciales para proyectos de bricolaje y construcción. Con este completo conjunto de herramientas eléctricas, estarás preparado para abordar una amplia gama de proyectos en el hogar. El taladro te permite perforar agujeros con precisión, mientras que la sierra circular facilita el corte de materiales como madera y metal. Además, otras herramientas incluidas te ayudarán a completar tareas de manera eficiente y profesional. Simplifica tus proyectos de bricolaje y construcción con esta caja de herramientas eléctricas todo en uno.", 10, "https://th.bing.com/th/id/OIP.OjhDY_0zOATiXAGtZyMQvgHaGN?rs=1&pid=ImgDetMain", "Caja de Herramientas Eléctricas", 250999m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("96b23940-0ca2-454b-8da1-a1183082ef2f"), 3, "Esta camiseta de algodón de manga corta es una elección perfecta para tu estilo casual. Con un estampado de logo que añade un toque de personalidad, te brinda comodidad y frescura durante todo el día. Ya sea para una salida informal o para relajarte en casa, esta camiseta se convertirá en un básico imprescindible en tu armario.", "https://59314.cdn.lojaquevende.com.br/static/59314/sku/masculino-camiseta-camiseta-adidas-originals-logo-rosa--p-1594925891821.jpg", "Camiseta Adidas Originals", 20000m },
                    { new Guid("97e974b3-a425-4ad8-93d2-234b3969c93f"), 9, "Novela de Paulo Coelho que narra la búsqueda de un joven por su destino y la realización personal. Sumérgete en este cautivador relato que sigue el viaje de autodescubrimiento de un protagonista en busca de su propósito en la vida. A través de encuentros inspiradores y desafíos emocionantes, la historia te lleva en un viaje transformador lleno de enseñanzas profundas y reflexiones sobre el destino y la libertad. Una lectura que te invita a reflexionar sobre tu propio camino hacia la realización personal.", "https://th.bing.com/th/id/OIP.sL5SnA4DPVj2aAJ0TRa05wHaLH?rs=1&pid=ImgDetMain", "Libro Bestseller: 'El Alquimista' de Paulo Coelho", 18200m },
                    { new Guid("98fbeb12-a085-4965-9ceb-7ac1ff62fc2a"), 4, "Silla de escritorio ergonómica con respaldo ajustable y ruedas para una comodidad óptima. Diseñada para brindar apoyo lumbar y mantener una postura adecuada durante largas sesiones de trabajo. Sus ruedas permiten una movilidad sin esfuerzo, mientras que su estilo moderno y funcional la convierte en el complemento perfecto para tu espacio de trabajo.", "https://http2.mlstatic.com/D_NQ_NP_855874-MLM28199817916_092018-F.jpg", "Silla Ergonómica de Oficina", 149999m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("99987f7a-b23d-4b1f-84a1-04bdc909271f"), 8, "Caja de vino tinto reserva con selección de las mejores añadas y variedades, ideal para ocasiones especiales y regalos. Disfruta de una experiencia enológica excepcional con esta cuidadosa selección de vinos. Cada botella representa lo mejor de su cosecha, ofreciendo una mezcla única de sabores y aromas. Perfecta para celebrar ocasiones especiales o como regalo para amigos y familiares, esta caja de vino reserva añade un toque de elegancia a cualquier evento. Sorprende a tus seres queridos con esta exquisita selección y comparte momentos memorables alrededor de una copa de vino.", 5, "https://sgfm.elcorteingles.es/SGFM/dctm/MEDIA03/202001/27/00118718001250____7__1200x1200.jpg", "Caja de Vino Tinto Reserva", 29999m },
                    { new Guid("9dde94eb-cdca-44aa-8b82-47ee44305978"), 3, "Gafas de sol polarizadas con montura de acetato y lentes UV400. Protege tus ojos con estilo y confort gracias a su diseño polarizado que reduce los reflejos y la fatiga visual. La montura de acetato ofrece durabilidad y elegancia, mientras que las lentes UV400 bloquean los dañinos rayos UV. Disfruta de una visión clara y nítida mientras te proteges del sol con estas gafas de calidad.", 10, "https://i5.walmartimages.com/asr/eaf39d77-26b2-4e40-a8a8-26f2d30869ad.9423bef8ef7337b1d8c576fb2513164e.jpeg?odnWidth=1000&odnHeight=1000&odnBg=ffffff", "Gafas de Sol Ray-Ban", 52999m },
                    { new Guid("9f55b4c2-dedf-475e-a2a0-babb40964f86"), 4, "Set de toallas de baño de algodón suave y absorbente, incluye toalla de baño, toalla de mano y toalla facial. Envuélvete en lujo y comodidad con este set de toallas que ofrece una experiencia de baño indulgente. Fabricadas con algodón de alta calidad, estas toallas son suaves al tacto y altamente absorbentes, proporcionando una sensación de frescura después de cada baño. Con tamaños adecuados para cada necesidad, desde la toalla de baño hasta la toalla facial, este set es imprescindible para cualquier baño bien equipado. Disfruta de la suavidad y la calidad que estas toallas brindan a tu rutina diaria de cuidado personal.", 2, "https://http2.mlstatic.com/D_NQ_NP_2X_655053-MLM40882494688_022020-F.jpg", "Set de Toallas de Baño de Algodón", 20000m },
                    { new Guid("a0816add-7e48-4796-9c3c-4e47406ea6fe"), 9, "Kit de iniciación a la pintura al óleo que incluye lienzos, pinturas y pinceles, ideal para artistas principiantes. Da tus primeros pasos en el mundo del arte con este completo kit que proporciona todo lo necesario para empezar a pintar al óleo. Los lienzos de calidad ofrecen una superficie perfecta para plasmar tu creatividad, mientras que las pinturas vibrantes te permiten experimentar con una amplia gama de colores. Además, los pinceles incluidos te ayudan a aplicar la pintura con precisión y detalle. Ya sea que estés explorando tu talento artístico o buscando una nueva afición, este kit es el punto de partida perfecto para tu viaje creativo.", 4, "https://a0.soysuper.com/5a574d66498bf9c0b98a1dd06ca83083.1500.0.0.0.wmark.0b04d770.jpg", "Kit de Iniciación a la Pintura al Óleo", 9736m },
                    { new Guid("a59d3e37-edfd-450a-b7e3-d4a4a06fd79d"), 4, "Cámara de seguridad WiFi con visión nocturna y detección de movimiento, ideal para monitorear tu hogar o negocio desde cualquier lugar. Mantén tu propiedad segura y protegida con esta cámara de seguridad avanzada que ofrece características de vanguardia. Con su conexión WiFi, puedes acceder al video en tiempo real desde tu teléfono inteligente o computadora, incluso cuando estás fuera de casa. La visión nocturna te permite mantener la vigilancia durante la noche, mientras que la detección de movimiento te alerta instantáneamente sobre cualquier actividad sospechosa. Con esta cámara, disfruta de una tranquilidad total al saber que puedes estar al tanto de lo que sucede en tu entorno en todo momento.", 10, "https://th.bing.com/th/id/OIP.IzJ0VcLsuEXb37n2OmILKQHaJL?rs=1&pid=ImgDetMain", "Cámara de Seguridad WiFi", 58399m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("a695e9f4-b8f8-40f0-9c05-d1219e3be92b"), 7, "Este set de bloques de construcción para niños es una fuente infinita de creatividad. Con figuras y accesorios variados, inspira la imaginación y el juego interactivo. Construye mundos imaginarios y fomenta habilidades motoras y cognitivas mientras los más pequeños se divierten. ¡Un regalo perfecto para horas de diversión y aprendizaje!", "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6252/6252643ld.jpg", "LEGO Classic Medium Box", 80000m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("a796a5c1-c693-4166-802f-0f8e66a0b304"), 5, "Set de brochas de maquillaje profesional con cerdas suaves y duraderas, ideal para aplicar maquillaje de forma precisa. Experimenta un acabado impecable con este completo set de brochas que ofrece todo lo necesario para crear looks de maquillaje profesionales. Las cerdas suaves y resistentes garantizan una aplicación uniforme y sin rayas, mientras que los mangos ergonómicos proporcionan un agarre cómodo y controlado. Desde la base hasta los detalles, cada brocha está diseñada para brindar precisión y versatilidad en cada paso de tu rutina de maquillaje. Eleva tu juego de maquillaje con este set de brochas imprescindible que te ayuda a lograr resultados de aspecto profesional.", 5, "https://th.bing.com/th/id/R.784d7e06420f061c505e49af947d5f2f?rik=RQ8Nqsk6zcrztg&pid=ImgRaw&r=0", "Set de Brochas de Maquillaje Profesional", 8999m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("a913eb0b-ecec-4205-92cc-c5614a81b8e8"), 1, "Robot de cocina multifunción con capacidad para cocinar una variedad de platos automáticamente. Simplifica tus tareas en la cocina con este robot versátil que hace todo por ti. Desde cortar y picar hasta cocinar y hornear, este dispositivo hace que preparar comidas sea rápido y fácil. Con su amplia gama de funciones y programas preestablecidos, puedes cocinar una variedad de platos con solo presionar un botón. Ya sea que seas un chef experimentado o un principiante en la cocina, este robot te ayuda a crear deliciosas comidas con facilidad y conveniencia.", "https://img.pccomponentes.com/articles/32/329974/9743-kenwood-kcook-multi-ccl401wh-robot-de-cocina-multifuncion-1500w-4ef0d08d-31ce-4704-8f55-6e0cfbbce775.jpg", "Robot de Cocina Multifunción", 511436m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("acf1deff-19b7-4ea0-b204-1aa2b884b09d"), 2, "Este portátil ligero ofrece una experiencia excepcional con su pantalla táctil de 14 pulgadas. Con 8 GB de RAM, disfruta de un rendimiento fluido y ágil para todas tus tareas diarias. Su diseño compacto y potente lo convierte en el compañero perfecto para la productividad y el entretenimiento sobre la marcha. Conéctate, crea y disfruta con total libertad.", 15, "https://th.bing.com/th/id/R.d2384bda8fccd883f9f8cf43a30413e7?rik=K9kvE0qdfX%2bq3Q&pid=ImgRaw&r=0", "Dell XPS 13", 2500000m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("b5517fd8-a966-4a08-b4a1-10a908785e1b"), 1, "Disfruta de una limpieza sin complicaciones con esta aspiradora sin bolsa. Equipada con tecnología ciclónica de vanguardia y un filtro HEPA, atrapa eficazmente el polvo y los alérgenos, asegurando un ambiente más saludable en tu hogar. Su diseño sin bolsa te proporciona comodidad adicional, mientras que su potente succión deja tus suelos impecables en cada pasada. Simplifica tu rutina de limpieza con este dispositivo eficiente y de alto rendimiento.", "https://i1.wp.com/webadictos.com/media/2020/06/dyson-v11-outsize-aspiradora_2.jpg?fit=1800%2C1800&ssl=1", "Aspiradora Dyson V11", 300000m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("b687aa32-bcf5-4878-b7b9-4baeb8ab9d00"), 9, "Robot educativo programable para niños que enseña conceptos de programación y robótica de forma divertida. Este robot interactivo ofrece una experiencia de aprendizaje emocionante, permitiendo a los niños explorar la programación y la robótica de manera práctica y entretenida. Con actividades y desafíos creativos, estimula el pensamiento lógico y fomenta la resolución de problemas. Prepárate para horas de diversión y descubrimiento mientras tus hijos desarrollan habilidades del siglo XXI con este increíble robot educativo.", 5, "https://images-eu.ssl-images-amazon.com/images/I/510gHu9VJ9L.jpg", "Robot Educativo para Niños", 30999m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("ba07b977-0e28-4262-be5a-05102c9cfea4"), 9, "Set de técnicas de dibujo a lápiz que incluye lápices de diferentes durezas, goma de borrar y bloc de dibujo, ideal para artistas principiantes y avanzados. Con este completo set, podrás explorar tu creatividad y mejorar tus habilidades de dibujo. Los lápices de diferentes durezas te permiten crear una amplia gama de efectos y detalles, mientras que la goma de borrar te ayuda a corregir errores fácilmente. Además, el bloc de dibujo ofrece una superficie de calidad para plasmar tus ideas. Ya seas principiante o avanzado, este set es una herramienta indispensable para expresar tu arte.", "https://th.bing.com/th/id/OIP.EOq0y7VygS2aCBA-zQND4AHaF4?w=680&h=540&rs=1&pid=ImgDetMain", "Set de Técnica de Dibujo a Lápiz", 6275m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("ba776724-9e82-4f3e-b870-42fba89447f9"), 2, "Cámara mirrorless de alta calidad con sensor APS-C y grabación de video 4K, ideal para fotógrafos aficionados y profesionales. Con su sensor avanzado, esta cámara captura imágenes detalladas y videos nítidos en una variedad de condiciones de iluminación. Su diseño compacto y ligero la hace perfecta para llevarla a todas partes, mientras que sus características avanzadas satisfacen las necesidades de fotógrafos de todos los niveles. Descubre un mundo de posibilidades creativas con esta cámara versátil y potente.", 10, "https://th.bing.com/th/id/R.095e4965c18d91a4ae3f3136df45c05d?rik=3FJqYjGVT02s1A&pid=ImgRaw&r=0", "Cámara Mirrorless Sony Alpha", 1399999m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("bb092e6a-6408-46c9-bedc-98c3d7b3a8ac"), 5, "Crema corporal hidratante con aroma de lavanda, envase de 250 ml. Nutre y suaviza tu piel con esta crema delicadamente perfumada. La lavanda ofrece propiedades relajantes y calmantes, mientras que la fórmula hidratante deja tu piel suave y tersa. Ideal para mimarte después de un largo día, esta crema te envuelve en un aroma reconfortante y te ayuda a relajarte. Disfruta de una piel radiante y perfumada con esta crema de calidad.", "https://mundoverde.com.pe/wp-content/uploads/2021/09/IMG_5203.jpg", "Crema Corporal Hidratante Lavanda", 7950m },
                    { new Guid("bc10c2a3-57cc-47d9-b21c-50bbacac0d03"), 6, "Balón de fútbol oficial de la FIFA, diseñado para un rendimiento óptimo. Juega como los profesionales con este balón de alta calidad. Diseñado y probado según los estándares de la FIFA, ofrece un rendimiento excepcional en el campo. Con un diseño aerodinámico y duradero, te proporciona precisión y control en cada golpe. Domina el juego con este balón que cumple con las exigencias de los mejores torneos del mundo.", "https://i.pinimg.com/originals/dc/8c/d2/dc8cd20e204181feda97133eaef73b7c.jpg", "Balón de Fútbol Adidas", 29999m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("bd0891de-8713-44a5-96b9-87119b23b91c"), 6, "Piano digital con teclas contrapesadas y múltiples voces y efectos, perfecto para principiantes y pianistas avanzados. Este piano ofrece una experiencia de interpretación auténtica con teclas contrapesadas que simulan la sensación de un piano acústico. Con una amplia variedad de voces y efectos, puedes explorar diferentes estilos musicales y expresar tu creatividad. Además, su diseño compacto lo hace ideal para espacios reducidos. Ya seas principiante o avanzado, este piano digital te brinda las herramientas necesarias para desarrollar tus habilidades musicales y disfrutar de horas de práctica y entretenimiento.", 14, "https://th.bing.com/th/id/R.16e5658bba363d72e7a3126bb6e69cd3?rik=8%2bjXEPN7vtQlmg&pid=ImgRaw&r=0", "Piano Digital Yamaha", 1545180m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("c28052a0-7d36-43aa-8479-b139764887f3"), 4, "Set de toallas de baño de algodón suave, incluye 6 piezas en varios colores. Renueva tu baño con este completo set de toallas que combina comodidad y estilo. Fabricadas con algodón suave y absorbente, estas toallas son perfectas para envolverte en lujo después de cada ducha. Con seis piezas en una variedad de colores, puedes coordinarlas fácilmente con la decoración de tu baño. Disfruta de la frescura y la suavidad en cada uso con este set de toallas de calidad.", "https://th.bing.com/th/id/OIP.UBiyo398JdTaO3EmEKSuZQHaHa?rs=1&pid=ImgDetMain", "Set de Toallas de Baño", 31999m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("c3c946b4-ca97-416a-b6d1-c93b5d56c39b"), 4, "Disfruta de un descanso óptimo con esta almohada de espuma viscoelástica. Su funda de bambú ofrece suavidad y frescura, mientras que la espuma viscoelástica se adapta a la forma de tu cabeza y cuello para un soporte personalizado. Experimenta un sueño reparador y despierta renovado cada mañana.", 10, "https://promart.vteximg.com.br/arquivos/ids/749561-1000-1000/image-1f6900df483d4c149f335f189d35f8ab.jpg?v=637490110244330000", "Almohada Viscoelástica", 20000m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("c4de2b1a-555b-4474-b1d8-7218264fb467"), 5, "Acondicionador capilar hidratante para cabello seco y dañado, envase de 500 ml. Revitaliza y restaura la salud de tu cabello con este acondicionador formulado específicamente para cabello seco y dañado. Su fórmula hidratante nutre profundamente cada hebra, dejando el cabello suave, sedoso y manejable. Convierte el cuidado del cabello en un placer diario y luce un cabello radiante y saludable.", "https://res.cloudinary.com/walmart-labs/image/upload/w_960,dpr_auto,f_auto,q_auto:best/gr/images/product-images/img_large/00750630622031L.jpg", "Acondicionador Capilar Hidratante", 8999m },
                    { new Guid("c969ffb8-3961-4798-b052-43c1d386f555"), 2, "Smartwatch con pantalla Retina siempre activa y seguimiento avanzado de la salud. Mantén un estilo de vida activo y saludable con este smartwatch que ofrece lo último en tecnología y funcionalidad. Su pantalla Retina siempre activa te permite ver la hora y tus datos de salud de un vistazo, mientras que el seguimiento avanzado de la salud monitoriza tus actividades físicas, frecuencia cardíaca y más. Con notificaciones en tiempo real y una amplia gama de aplicaciones, es tu compañero perfecto para alcanzar tus objetivos de bienestar.", "https://th.bing.com/th/id/R.a7387a7dc217cdeb0af458095dce22f8?rik=WU6fcZ7espeomA&pid=ImgRaw&r=0", "Smartwatch Apple Watch Series 7", 394994m },
                    { new Guid("cc9b4471-af00-4fbf-affe-b04462e68621"), 2, "Laptop ultradelgada con pantalla OLED de 15.6 pulgadas y procesador Intel Core i7. Experimenta la potencia y la elegancia en un solo dispositivo con esta laptop ultradelgada. La pantalla OLED ofrece colores vibrantes y negros profundos, mientras que el procesador Intel Core i7 garantiza un rendimiento excepcional. Con un diseño elegante y ligero, es ideal para trabajar o disfrutar de contenido multimedia en cualquier lugar. Hazte con esta laptop y lleva tu productividad a un nuevo nivel.", "https://th.bing.com/th/id/R.ae6ed7bc1d14a535b8f210b80a24366a?rik=4jze262VE41JUg&pid=ImgRaw&r=0", "Laptop Dell XPS 15", 230000m },
                    { new Guid("d1286dbc-bef7-4f03-914e-60d71fc792f3"), 4, "Juego de toallas de baño de algodón, incluye 2 toallas de mano y 2 de baño. Dale un toque de lujo a tu baño con este juego de toallas suaves y absorbentes. Fabricadas con algodón de alta calidad, ofrecen una sensación de confort y frescura después de cada ducha. Con un diseño elegante y duradero, son el complemento perfecto para tu rutina de cuidado personal. Disfruta de la máxima comodidad y estilo en tu hogar.", "https://www.sedalinne.com/blog/wp-content/uploads/2016/06/CATALOGO-ENERO-2016-BAJA-42-1024x1024.jpg", "Set de Toallas de Baño comunes", 23999m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("d1b9df42-9b58-43f4-8030-0aafacf642e8"), 8, "Máquina de café espresso automática con vaporizador de leche, ideal para preparar café de alta calidad en casa. Disfruta de la experiencia de una cafetería en la comodidad de tu hogar con esta máquina de café espresso de última generación. Con su funcionamiento automático, puedes preparar fácilmente deliciosos espressos, cappuccinos y lattes con solo tocar un botón. El vaporizador de leche te permite crear una espuma cremosa para tus bebidas favoritas. Además, su diseño elegante y compacto se adapta perfectamente a cualquier cocina. Eleva tu rutina matutina con café de alta calidad preparado al instante con esta máquina de café espresso automática.", 10, "https://th.bing.com/th/id/OIP.Rdeajhi-q30zNGPlcQvG5gHaHa?rs=1&pid=ImgDetMain", "Máquina de Café Espresso", 236550m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("d291299c-c1b7-4c77-b41d-94b40051d95f"), 8, "Botella de whisky escocés single malt de añejamiento prolongado y sabor suave y complejo. Disfruta de la excelencia de la destilería escocesa con esta botella que ofrece una experiencia de sabor excepcional. El proceso de añejamiento prolongado le otorga al whisky una suavidad y complejidad únicas, con notas aromáticas y sabores profundos que deleitan el paladar. Ya sea que lo disfrutes solo, con hielo o en un cóctel, este whisky single malt es la elección perfecta para momentos de celebración y disfrute.", "https://drinkland.co.nz/wp-content/uploads/2020/08/Highland-Park-18-Year-Old-Orkney-Single-Malt-Scotch-Whisky-700mL-02.jpg", "Whisky Escocés Single Malt", 69999m },
                    { new Guid("d581b28d-cea9-48d3-8b9c-c33a5446435f"), 8, "Set de tazas de café de porcelana con diseño elegante y moderno, ideal para disfrutar del café en casa o en la oficina. Eleva tu experiencia de café con este conjunto de tazas que combinan estilo y funcionalidad. Fabricadas con porcelana de alta calidad, estas tazas ofrecen una apariencia elegante y una sensación confortable al sostenerlas. Con su diseño moderno, son el complemento perfecto para cualquier decoración de cocina u oficina. Disfruta de momentos de tranquilidad con una taza de café perfectamente servida en este set de tazas excepcional.", "https://http2.mlstatic.com/D_NQ_NP_962633-MLB45600780976_042021-F.jpg", "Set de Tazas de Café de Porcelana", 34087m },
                    { new Guid("d59cc62a-1521-4a50-9e1a-cdb5dad5686b"), 7, "Rompecabezas en 3D de la famosa Torre Eiffel, ideal para entusiastas de la arquitectura. Vive la experiencia de construir uno de los íconos arquitectónicos más reconocidos del mundo con este rompecabezas en 3D. Cada pieza de este desafío te acerca más a la majestuosidad de la Torre Eiffel, mientras ejercitas tu mente y desarrollas habilidades espaciales. Perfecto para entusiastas de la arquitectura y amantes de los rompecabezas, este set ofrece horas de diversión y satisfacción al completar esta obra maestra en miniatura.", "https://www.toysbestideas.com/images/123586/BuilDream-3D-Puzzle-Eiffel-Tower-66-pieces-2.jpg", "Rompecabezas 3D de la Torre Eiffel", 25655m },
                    { new Guid("d6321dd4-978e-44fd-8bb1-92d8ee2d5015"), 8, "Set de té de porcelana con tetera, tazas y platillos, elegante y perfecto para disfrutar de una tarde de té. Eleva tus momentos de té con este exquisito set de porcelana que combina elegancia y funcionalidad. Con una tetera y tazas a juego, junto con platillos coordinados, cada pieza añade un toque de sofisticación a tu ritual de té. Ya sea que disfrutes de una tarde tranquila o invites a amigos a compartir, este set es el compañero ideal para disfrutar de una experiencia de té refinada y memorable.", "https://images-na.ssl-images-amazon.com/images/I/81fFHmBTqgL._AC_SL1500_.jpg", "Set de Té de Porcelana", 175227m },
                    { new Guid("d6ae20cc-c341-4137-8bc4-46b8d0c80320"), 7, "Muñeca Barbie Fashionista con diversidad de estilos y looks para inspirar el juego creativo. ¡Desata tu creatividad y estilo con la muñeca Barbie Fashionista! Con una amplia gama de estilos y looks diversos, esta muñeca es el lienzo perfecto para crear historias y aventuras únicas. Desde atuendos elegantes hasta conjuntos deportivos, cada Barbie Fashionista refleja la diversidad y la moda del mundo real. ¡Explora tu imaginación y crea tus propias tendencias con Barbie!", "https://i5.walmartimages.com/asr/a50d9058-03a5-4094-bf53-e6c4a860daab_1.a76618ad67f4cd87d4fd69421b627db4.jpeg?odnWidth=1000&odnHeight=1000&odnBg=ffffff", "Muñeca Barbie Fashionista", 19999m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("d95a284f-4b5c-480d-8dc0-2bc756ac7a7c"), 1, "Aspiradora robot inteligente con mapeo de habitaciones y control por voz. Simplifica la limpieza de tu hogar con esta aspiradora robot de última generación. Su capacidad de mapeo de habitaciones te permite programarla para limpiar áreas específicas, mientras que el control por voz ofrece comodidad y facilidad de uso. Con sensores avanzados, evita obstáculos y limpia de manera eficiente. Disfruta de un hogar limpio y ordenado con esta aspiradora inteligente.", 5, "https://ojeando.es/wp-content/uploads/2020/06/irobot-roomba-e5.jpg", "Aspiradora Robot Roomba", 499999m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("dad6da5d-2bc4-4824-b978-36dad771f1fe"), 6, "Zapatillas deportivas con amortiguación reactiva y suela de tracción para correr cómodamente. Alcanza tus metas de entrenamiento con estas zapatillas diseñadas para brindarte comodidad y rendimiento. La amortiguación reactiva absorbe el impacto de cada paso, mientras que la suela de tracción proporciona agarre y estabilidad en una variedad de superficies. Ya sea en el gimnasio o en la pista, estas zapatillas te permiten correr con confianza y comodidad.", "https://th.bing.com/th/id/R.59588929ca4c74f1d2b80c4444c86b8a?rik=%2bKysx8%2bM2A%2fGPA&pid=ImgRaw&r=0", "Zapatillas Deportivas Nike Air Zoom Pegasus", 120911m },
                    { new Guid("dbabf9bc-a113-482f-afb3-659ccdab7162"), 5, "Kit completo de cuidado de la piel que incluye limpiador facial, tónico, crema hidratante, etc. Transforma tu rutina de cuidado facial con este completo kit diseñado para nutrir y rejuvenecer tu piel. El limpiador facial elimina suavemente las impurezas, el tónico equilibra y refresca, mientras que la crema hidratante proporciona una hidratación profunda y duradera. Con otros productos esenciales incluidos, este kit ofrece todo lo necesario para una piel radiante y saludable en cada paso.", "https://th.bing.com/th/id/R.82e5011d4e83c3daa6edd05b048f7540?rik=5pykmWYyLs%2fYTg&pid=ImgRaw&r=0", "Kit de Cuidado de la Piel", 49899m },
                    { new Guid("df618063-418a-4e4e-92ec-6052fd49767f"), 7, "Set de construcción LEGO Star Wars con figuras de personajes y naves espaciales. Embárcate en épicas aventuras galácticas con este set de construcción que combina la emoción de Star Wars con la creatividad de LEGO. Incluye figuras de tus personajes favoritos y detalladas naves espaciales para recrear escenas memorables de la saga. Con instrucciones paso a paso, te sumergirás en el universo Star Wars mientras construyes y juegas. ¡Que la Fuerza esté contigo mientras exploras este emocionante set LEGO!", "https://th.bing.com/th/id/R.c445de809477f17f095b1adc755913ad?rik=2kszFgqC9w9Byw&pid=ImgRaw&r=0", "Set de Construcción LEGO Star Wars", 89999m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("e064373d-702c-45db-8eee-45438a9d46ef"), 4, "Juego de cubiertos de acero inoxidable para 8 personas, resistente y apto para lavavajillas. Completa tu mesa con este elegante juego de cubiertos que combina funcionalidad y estilo. Fabricado con acero inoxidable de alta calidad, este juego es duradero y resistente a la corrosión. Con capacidad para 8 personas, es perfecto para reuniones familiares o cenas con amigos. Además, su diseño clásico y atemporal se adapta a cualquier ocasión. Disfruta de la conveniencia y la elegancia en cada comida.", 5, "https://th.bing.com/th/id/R.d5388c8d030aa3f391bd815c116ace27?rik=Cjuzlr2DnD7Dlg&pid=ImgRaw&r=0", "Juego de Cubiertos de Acero Inoxidable", 49797m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("e15f2574-4442-4e6b-b93a-95bdabacd65c"), 8, "Kit completo para hacer sushi en casa, incluye moldes, esterilla de bambú y utensilios para preparar sushi de calidad profesional. Con este kit, puedes disfrutar de deliciosos rollos de sushi caseros como un verdadero chef. Los moldes facilitan la creación de rollos perfectamente formados, mientras que la esterilla de bambú te ayuda a enrollar el sushi con precisión. Además, los utensilios de calidad profesional garantizan un acabado impecable en cada bocado. Sorprende a tus invitados o simplemente disfruta de una comida japonesa auténtica en la comodidad de tu hogar.", "https://images-na.ssl-images-amazon.com/images/I/81Dk-MyDZEL._AC_SL1500_.jpg", "Kit de Sushi Casero", 19099m },
                    { new Guid("e255ee64-6c27-409c-b024-ba91788ca984"), 4, "Cama individual con estructura de madera maciza y cabecero acolchado. Añade estilo y comodidad a tu dormitorio con esta cama de calidad. La robusta estructura de madera maciza garantiza durabilidad y estabilidad, mientras que el cabecero acolchado brinda un toque de elegancia y confort. Crea un ambiente acogedor y relajante para tus noches de descanso.", "https://vuanem.com/blog/wp-content/uploads/2022/06/mau-giuong-go-chan-cao2.png", "Cama Individual de Madera", 58600m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("e696a830-001b-4888-8352-ae87167ccfb8"), 4, "Set de platos de cerámica para servir comidas con estilo, resistente y apto para lavavajillas, ideal para uso diario o ocasiones especiales. Dale un toque de elegancia a tu mesa con este set de platos que combina funcionalidad y diseño. Fabricados con cerámica duradera, estos platos son resistentes y pueden soportar el uso diario. Además, su acabado apto para lavavajillas facilita la limpieza después de cada comida. Ya sea para una cena informal en casa o una ocasión especial, este set de platos es perfecto para servir tus platos favoritos con estilo.", 2, "https://th.bing.com/th/id/OIP.p9WgOXbClrrXRrQaLmW-EwHaHa?w=1500&h=1500&rs=1&pid=ImgDetMain", "Set de Platos de Cerámica", 55000m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("eaf51e28-3724-4425-88bd-13504bf5aedf"), 4, "Lámpara de pie moderna con pantalla ajustable y luz regulable, ideal para iluminar cualquier espacio de forma elegante. Agrega un toque de estilo y funcionalidad a tu hogar con esta lámpara de pie contemporánea. Su pantalla ajustable te permite dirigir la luz según tus necesidades, mientras que la función de luz regulable te permite crear diferentes ambientes según el momento del día. Ya sea en el salón, la oficina o el dormitorio, esta lámpara ofrece una iluminación versátil y sofisticada que complementa cualquier decoración. Disfruta de un ambiente acogedor y bien iluminado con esta lámpara moderna y elegante.", "https://mla-s1-p.mlstatic.com/786581-MLA26434101358_112017-B.jpg", "Lámpara de Pie Moderna", 24500m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("ecc3348e-ed68-4140-a20b-83ac1ba265bd"), 4, "Set de cuchillos de cocina de acero inoxidable, incluye 5 piezas. Equipa tu cocina con este versátil set de cuchillos diseñado para todas tus necesidades culinarias. Fabricados con acero inoxidable de alta calidad, estos cuchillos ofrecen durabilidad y precisión en cada corte. Con una variedad de tamaños y estilos, desde el cuchillo de chef hasta el cuchillo para pan, estarás preparado para cualquier tarea en la cocina. Simplifica tu preparación de alimentos y eleva tu experiencia culinaria con este set de cuchillos imprescindible.", 10, "https://images-na.ssl-images-amazon.com/images/I/71P0lGwQ%2BSL._AC_SL1500_.jpg", "Set de Cuchillos de Cocina", 48999m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("ed23a8ee-d743-49cd-9adb-0d3bac253329"), 8, "Caja de chocolates gourmet de alta calidad, ideal para regalar o disfrutar en ocasiones especiales. Deléitate con esta exquisita selección de chocolates elaborados con los mejores ingredientes. Cada bocado es una experiencia indulgente que deleitará tus sentidos. Presentada en una elegante caja, es el regalo perfecto para cualquier ocasión especial o simplemente para darte un capricho. Disfruta de momentos dulces y memorables con esta caja de chocolates gourmet.", "https://i5.walmartimages.com/asr/007378ed-c963-4fd9-b5d8-733722f4608f.1f45d6c682c9254f0f15baa1d88c9212.jpeg", "Caja de Chocolates Gourmet", 49779m },
                    { new Guid("ed483d73-6d91-4c8a-ad04-a3a3f0a78175"), 3, "Bufanda de lana suave y cálida tejida a mano, perfecta para los días fríos de invierno. Envuélvete en calidez y confort con esta bufanda cuidadosamente tejida a mano. Fabricada con lana de alta calidad, ofrece una suavidad excepcional y una sensación reconfortante alrededor del cuello. Su diseño tejido a mano le añade un toque de artesanía y estilo único. Ya sea para pasear al aire libre o para complementar tu atuendo, esta bufanda es el accesorio esencial para enfrentar los rigores del invierno con estilo.", "https://th.bing.com/th/id/OIP.7Rnzy4JWNkkc5qeBu6KpJAHaO3?rs=1&pid=ImgDetMain", "Bufanda de Lana Tejida a Mano", 16999m },
                    { new Guid("f01257f5-8249-4610-8e99-a547196b6aee"), 4, "Plancha de vapor con suela de cerámica y función de autoapagado. Simplifica tus tareas de planchado con esta plancha de alta calidad. La suela de cerámica asegura un deslizamiento suave sobre cualquier tejido, mientras que la función de autoapagado proporciona seguridad y tranquilidad. Con un diseño ergonómico y eficiente, logra resultados impecables en menos tiempo. Haz que el planchado sea más fácil y efectivo con esta plancha innovadora.", "https://images.philips.com/is/image/PhilipsConsumer/GC5036_20-IMS-es_ES?$jpglarge$&wid=1250", "Plancha de Vapor Philips", 114251m },
                    { new Guid("f052c6fb-7c8c-4d27-88fe-6825c8ce0b24"), 5, "Kit completo de maquillaje profesional con sombras de ojos, labiales y brochas. Transforma tu look con este kit de maquillaje que incluye todo lo que necesitas para crear looks impresionantes. Las sombras de ojos en una variedad de tonos te permiten experimentar con diferentes estilos, mientras que los labiales añaden un toque de color y glamour. Las brochas de alta calidad facilitan la aplicación precisa y mezcla de los productos. Eleva tu juego de maquillaje con este kit completo y versátil.", "https://m.media-amazon.com/images/I/71wo93nsVEL._AC_SL1500_.jpg", "Kit de Maquillaje Profesional", 49999m },
                    { new Guid("f2241713-2828-4601-8a6b-4f25787f7a8f"), 10, "Este completo set de herramientas de mano es imprescindible para reparaciones domésticas. Con una variedad de herramientas de alta calidad, desde destornilladores hasta llaves ajustables, estarás listo para abordar cualquier proyecto. Robustas, duraderas y organizadas en un práctico estuche, hacen que las tareas de bricolaje sean más fáciles y satisfactorias.", "https://fravega.vteximg.com.br/arquivos/ids/312150-1000-1000/Set-de-herramientas-manuales-Black--Decker-HDT51-910.jpg?v=636392310833070000", "Kit de Herramientas Black+Decker", 79999m },
                    { new Guid("f2d5e600-f7a0-4b16-ae76-5ebc19a98332"), 2, "Teclado mecánico para juegos con retroiluminación RGB y switches Cherry MX Red. Domina tus juegos con este teclado diseñado para ofrecer un rendimiento excepcional. Los switches Cherry MX Red proporcionan una pulsación suave y lineal, perfecta para una respuesta rápida en tus partidas. La retroiluminación RGB te permite personalizar la iluminación según tu estilo y preferencias. Con este teclado, disfruta de una experiencia de juego inigualable y haz que cada movimiento cuente.", "https://c1.neweggimages.com/ProductImageCompressAll1280/23-816-135-V03.jpg", "Teclado Mecánico Corsair K95 RGB", 319919m },
                    { new Guid("f3460aae-486d-46d3-bca0-fa8e0504c14f"), 10, "Kit de herramientas completo para proyectos de bricolaje en casa, incluye martillo, destornilladores, etc. Equipa tu hogar con este completo conjunto de herramientas que te ayuda a abordar una amplia variedad de proyectos de bricolaje. Con un martillo resistente, destornilladores de varios tamaños, llaves ajustables y más, tienes todo lo necesario para reparaciones, montaje de muebles y otros trabajos en casa. Simplifica tus tareas de mantenimiento con este práctico y versátil kit de herramientas.", "https://th.bing.com/th/id/R.c1ff43ceb1f9ecbfc022cee8446fdb87?rik=nt0dMENPO0E50g&pid=ImgRaw&r=0", "Kit de Herramientas de Bricolaje", 79899m },
                    { new Guid("f3fd4ef4-bd7e-4eaf-87ff-96d5f4e10194"), 4, "Juego de sábanas de algodón suave y transpirable, incluye sábana bajera, sábana encimera y fundas de almohada. Sumérgete en la comodidad y el lujo con este juego de sábanas que ofrece una experiencia de sueño excepcional. Fabricadas con algodón suave y transpirable, estas sábanas te envuelven en un confort acogedor durante toda la noche. El set completo incluye una sábana bajera ajustable, una sábana encimera y fundas de almohada a juego, garantizando una coordinación perfecta en tu dormitorio. Disfruta de noches de descanso reparador con este juego de sábanas de alta calidad.", "https://plazavea.vteximg.com.br/arquivos/ids/1924200-1000-1000/image-227bf6269da546e5b89a752ce83f8841.jpg?v=637595583785970000", "Juego de Sábanas de Algodón", 18899m },
                    { new Guid("f8b88960-b255-4b22-8bde-6f112d5e159d"), 7, "Set de juegos de mesa clásicos que incluye ajedrez, damas y backgammon, perfecto para disfrutar en familia o con amigos. Reúnete alrededor de la diversión con este versátil set que ofrece horas de entretenimiento. Tres juegos clásicos en un solo conjunto, brindando variedad y emoción para todas las edades. Desde estrategias complejas en el ajedrez hasta la diversión tradicional de las damas y la emoción del backgammon, hay algo para todos. Aprovecha la oportunidad para crear recuerdos memorables y fortalecer los lazos familiares y de amistad con este completo set de juegos de mesa.", "https://http2.mlstatic.com/D_NQ_NP_677379-MLC44163778741_112020-F.jpg", "Set de Juegos de Mesa", 19999m },
                    { new Guid("f8e7b22a-72fd-4bc6-9b98-aa5a953dcae4"), 5, "Protege y nutre tu piel con esta crema hidratante facial de día con SPF 30. Formulada para todo tipo de piel, ofrece una hidratación intensa y una protección eficaz contra los daños causados por los rayos UV. Su fórmula ligera y no grasa la hace perfecta para usar bajo el maquillaje, proporcionando una piel suave, radiante y protegida durante todo el día.", "https://plazavea.vteximg.com.br/arquivos/ids/234854-1000-1000/20125136.jpg?v=637030655810000000", "Crema Hidratante Facial Neutrogena", 8000m },
                    { new Guid("face3f79-7cce-4e17-97dd-fa66edf9b0e6"), 6, "Juego de mesa estratégico que te transporta a la era de los descubrimientos, ideal para reuniones familiares y de amigos. Vive la emoción de la exploración y el comercio en este juego que recrea la fascinante era de los descubrimientos. Con desafíos estratégicos y decisiones importantes, cada partida ofrece una experiencia única llena de diversión y aprendizaje. Perfecto para compartir con familiares y amigos, este juego promueve la camaradería y la competencia saludable en cada encuentro.", "https://mejoresjuegosdemesade.com/wp-content/uploads/2020/11/pic17996-scaled.jpg", "Juego de Mesa 'Catan'", 15000m },
                    { new Guid("fc01fd92-5c2d-4bc3-b3a4-d1faa2b07f1d"), 5, "Set de pinceles de maquillaje de alta calidad para aplicar bases, sombras de ojos, rubor y más, diseñado para una aplicación precisa. Crea looks impecables con este set de pinceles que cubre todas tus necesidades de maquillaje. Con una variedad de formas y tamaños, estos pinceles te permiten aplicar y difuminar productos de manera uniforme y profesional. Fabricados con materiales de alta calidad, son suaves en la piel y duraderos. Eleva tu rutina de belleza con estos pinceles imprescindibles que te ayudarán a lograr resultados de aspecto impecable.", "https://www.theoria.fr/wp-content/uploads/2020/11/71wtJakwpmL._AC_SL1500_.jpg", "Set de Pinceles de Maquillaje", 15000m },
                    { new Guid("fe806b70-12e7-4704-8026-291f23c1df17"), 9, "Set de pinceles de diferentes tamaños y lienzos para pintura, perfecto para artistas aficionados y profesionales. Exprésate a través del arte con este completo set que ofrece todo lo necesario para dejar volar tu creatividad. Los pinceles de varios tamaños te permiten trabajar con precisión y detalle, mientras que los lienzos de calidad ofrecen una superficie perfecta para tus creaciones. Ya seas un principiante entusiasta o un artista experimentado, este set es tu compañero ideal en el mundo de la pintura.", "https://images-na.ssl-images-amazon.com/images/I/A1GwBEDZgFL._AC_SL1500_.jpg", "Set de Pinceles y Lienzos para Pintura", 33939m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[] { new Guid("fe896756-3579-42f1-addd-50000433dcdd"), 6, "Potencia tu juego con esta raqueta de tenis de carbono. Equipada con tecnología de absorción de impactos, ofrece una sensación suave y controlada en cada golpe. Su diseño ligero y aerodinámico te permite deslizarte por la pista con facilidad, mientras que la construcción de carbono proporciona una combinación perfecta de potencia y precisión. Domina la cancha con estilo y confianza.", 15, "https://http2.mlstatic.com/D_NQ_NP_2X_794390-MLM43617620753_092020-F.jpg", "Raqueta de Tenis Wilson Pro Staff", 180000m });

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category",
                table: "Product",
                column: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Name",
                table: "Product",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SaleProduct_Product",
                table: "SaleProduct",
                column: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_SaleProduct_Sale",
                table: "SaleProduct",
                column: "Sale");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleProduct");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
