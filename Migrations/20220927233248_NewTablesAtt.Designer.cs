// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyHotel.Data;

#nullable disable

namespace MyHotel.Migrations
{
    [DbContext(typeof(ContextoBD))]
    [Migration("20220927233248_NewTablesAtt")]
    partial class NewTablesAtt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyHotel.Models.Agendamentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool?>("Confirmado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("DiaFuncionamentoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProcedimentoId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiaFuncionamentoId");

                    b.HasIndex("ProcedimentoId");

                    b.HasIndex("UserId");

                    b.ToTable("Agendamento");
                });

            modelBuilder.Entity("MyHotel.Models.DiaFuncionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("DiaFuncionamentos");
                });

            modelBuilder.Entity("MyHotel.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("MyHotel.Models.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Perfis");
                });

            modelBuilder.Entity("MyHotel.Models.Procedimentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(13,2)");

                    b.HasKey("Id");

                    b.ToTable("Procedimento");
                });

            modelBuilder.Entity("MyHotel.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PerfilUser", b =>
                {
                    b.Property<int>("PerfisId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("PerfisId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("PerfilUser");
                });

            modelBuilder.Entity("MyHotel.Models.Agendamentos", b =>
                {
                    b.HasOne("MyHotel.Models.DiaFuncionamento", "DiaFuncionamento")
                        .WithMany("Agendamentos")
                        .HasForeignKey("DiaFuncionamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyHotel.Models.Procedimentos", "Procedimento")
                        .WithMany("Agendamentos")
                        .HasForeignKey("ProcedimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyHotel.Models.User", "Cliente")
                        .WithMany("Agendamentos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("DiaFuncionamento");

                    b.Navigation("Procedimento");
                });

            modelBuilder.Entity("MyHotel.Models.Endereco", b =>
                {
                    b.HasOne("MyHotel.Models.User", "User")
                        .WithOne("Endereco")
                        .HasForeignKey("MyHotel.Models.Endereco", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PerfilUser", b =>
                {
                    b.HasOne("MyHotel.Models.Perfil", null)
                        .WithMany()
                        .HasForeignKey("PerfisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyHotel.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyHotel.Models.DiaFuncionamento", b =>
                {
                    b.Navigation("Agendamentos");
                });

            modelBuilder.Entity("MyHotel.Models.Procedimentos", b =>
                {
                    b.Navigation("Agendamentos");
                });

            modelBuilder.Entity("MyHotel.Models.User", b =>
                {
                    b.Navigation("Agendamentos");

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
