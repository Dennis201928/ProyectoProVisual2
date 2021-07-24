using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Persistencia.Migrations
{
    public partial class CargaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "generos",
                columns: table => new
                {
                    generoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomgenero = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generos", x => x.generoId);
                });

            migrationBuilder.CreateTable(
                name: "ivas",
                columns: table => new
                {
                    ivaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    im_sali_divisas = table.Column<float>(type: "real", nullable: false),
                    im_val_agregado = table.Column<float>(type: "real", nullable: false),
                    arancel = table.Column<float>(type: "real", nullable: false),
                    imrodaje = table.Column<float>(type: "real", nullable: false),
                    im_sali_divisas_isd = table.Column<float>(type: "real", nullable: false),
                    TotalIva = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ivas", x => x.ivaId);
                });

            migrationBuilder.CreateTable(
                name: "marcas",
                columns: table => new
                {
                    marcaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nommarca = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.marcaId);
                });

            migrationBuilder.CreateTable(
                name: "modelos",
                columns: table => new
                {
                    modeloId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_modelo = table.Column<string>(type: "text", nullable: true),
                    color = table.Column<string>(type: "text", nullable: true),
                    npuertas = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modelos", x => x.modeloId);
                });

            migrationBuilder.CreateTable(
                name: "tipopagos",
                columns: table => new
                {
                    tipopagoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombreTipoPago = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipopagos", x => x.tipopagoId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    clienteId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(type: "text", nullable: true),
                    edad = table.Column<int>(type: "integer", nullable: false),
                    generoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.clienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_generos_generoId",
                        column: x => x.generoId,
                        principalTable: "generos",
                        principalColumn: "generoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "carros",
                columns: table => new
                {
                    carroId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    modeloId = table.Column<int>(type: "integer", nullable: false),
                    marcaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carros", x => x.carroId);
                    table.ForeignKey(
                        name: "FK_carros_marcas_marcaId",
                        column: x => x.marcaId,
                        principalTable: "marcas",
                        principalColumn: "marcaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_carros_modelos_modeloId",
                        column: x => x.modeloId,
                        principalTable: "modelos",
                        principalColumn: "modeloId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ventas",
                columns: table => new
                {
                    ventaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    clienteId = table.Column<int>(type: "integer", nullable: false),
                    carroId = table.Column<int>(type: "integer", nullable: false),
                    tipopagoId = table.Column<int>(type: "integer", nullable: false),
                    precio = table.Column<int>(type: "integer", nullable: false),
                    ivaId = table.Column<int>(type: "integer", nullable: false),
                    total = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ventas", x => x.ventaId);
                    table.ForeignKey(
                        name: "FK_ventas_carros_carroId",
                        column: x => x.carroId,
                        principalTable: "carros",
                        principalColumn: "carroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ventas_Clientes_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Clientes",
                        principalColumn: "clienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ventas_ivas_ivaId",
                        column: x => x.ivaId,
                        principalTable: "ivas",
                        principalColumn: "ivaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ventas_tipopagos_tipopagoId",
                        column: x => x.tipopagoId,
                        principalTable: "tipopagos",
                        principalColumn: "tipopagoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_carros_marcaId",
                table: "carros",
                column: "marcaId");

            migrationBuilder.CreateIndex(
                name: "IX_carros_modeloId",
                table: "carros",
                column: "modeloId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_generoId",
                table: "Clientes",
                column: "generoId");

            migrationBuilder.CreateIndex(
                name: "IX_ventas_carroId",
                table: "ventas",
                column: "carroId");

            migrationBuilder.CreateIndex(
                name: "IX_ventas_clienteId",
                table: "ventas",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ventas_ivaId",
                table: "ventas",
                column: "ivaId");

            migrationBuilder.CreateIndex(
                name: "IX_ventas_tipopagoId",
                table: "ventas",
                column: "tipopagoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ventas");

            migrationBuilder.DropTable(
                name: "carros");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "ivas");

            migrationBuilder.DropTable(
                name: "tipopagos");

            migrationBuilder.DropTable(
                name: "marcas");

            migrationBuilder.DropTable(
                name: "modelos");

            migrationBuilder.DropTable(
                name: "generos");
        }
    }
}
