using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Projecta.MODELS;

namespace Projecta.DAL;

public partial class BdProjectaGroupContext : DbContext
{
    public BdProjectaGroupContext()
    {
    }

    public BdProjectaGroupContext(DbContextOptions<BdProjectaGroupContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Antiguedad> Antiguedads { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<Calificacion> Calificacions { get; set; }

    public virtual DbSet<Caso> Casos { get; set; }

    public virtual DbSet<CasoAgendada> CasoAgendada { get; set; }

    public virtual DbSet<CasoCertificaciones> CasoCertificaciones { get; set; }

    public virtual DbSet<CasoEvidencia> CasoEvidencia { get; set; }

    public virtual DbSet<CasoFechaSugerida> CasoFechaSugerida { get; set; }

    public virtual DbSet<CasoHerramienta> CasoHerramientas { get; set; }

    public virtual DbSet<CasoProducto> CasoProductos { get; set; }

    public virtual DbSet<CasoRiesgo> CasoRiesgos { get; set; }

    public virtual DbSet<CategoriaSubCategoria> CategoriaSubCategoria { get; set; }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Certificaciones> Certificaciones { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Cotizacion> Cotizacions { get; set; }

    public virtual DbSet<CotizacionImpuesto> CotizacionImpuestos { get; set; }

    public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }

    public virtual DbSet<Divisa> Divisas { get; set; }

    public virtual DbSet<EncuestaEvidencia> EncuestaEvidencia { get; set; }

    public virtual DbSet<Encuesta> Encuesta { get; set; }

    public virtual DbSet<Evidencia> Evidencias { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FacturaImpuesto> FacturaImpuestos { get; set; }

    public virtual DbSet<FechaAgendada> FechaAgendada { get; set; }

    public virtual DbSet<FechaSugerida> FechaSugerida { get; set; }

    public virtual DbSet<FileData> FileData { get; set; }

    public virtual DbSet<Herramienta> Herramientas { get; set; }

    public virtual DbSet<Imagen> Imagens { get; set; }

    public virtual DbSet<Impuesto> Impuestos { get; set; }

    public virtual DbSet<Mensaje> Mensajes { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuRol> MenuRols { get; set; }

    public virtual DbSet<NivelDificultad> NivelDificultads { get; set; }

    public virtual DbSet<NumeroDocumento> NumeroDocumentos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Regimen> Regimen { get; set; }

    public virtual DbSet<Riesgo> Riesgos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Rubro> Rubros { get; set; }

    public virtual DbSet<RubroCaso> RubroCasos { get; set; }

    public virtual DbSet<RubroCompany> RubroCompanies { get; set; }

    public virtual DbSet<RubroProducto> RubroProductos { get; set; }

    public virtual DbSet<Sector> Sectors { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<ServicioCaso> ServicioCasos { get; set; }

    public virtual DbSet<ServicioCategorium> ServicioCategoria { get; set; }

    public virtual DbSet<ServicioHerramienta> ServicioHerramientas { get; set; }

    public virtual DbSet<ServicioProducto> ServicioProductos { get; set; }

    public virtual DbSet<ServicioRiesgo> ServicioRiesgos { get; set; }

    public virtual DbSet<Simulacion> Simulacions { get; set; }

    public virtual DbSet<Subcategorium> Subcategoria { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoPago> TipoPagos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioBanco> UsuarioBancos { get; set; }

    public virtual DbSet<UsuarioCalificacion> UsuarioCalificacions { get; set; }

    public virtual DbSet<UsuarioCertificaciones> UsuarioCertificaciones { get; set; }

    public virtual DbSet<UsuarioChat> UsuarioChats { get; set; }

    public virtual DbSet<UsuarioCompany> UsuarioCompanies { get; set; }

    public virtual DbSet<UsuarioNivel> UsuarioNivels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-3IGCDU9\\SQLEXPRESS;Database=BD_ProjectaGroup;Integrated Security=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Antiguedad>(entity =>
        {
            entity.HasKey(e => e.IdAntiguedad).HasName("PK__Antigued__4E33108F536B85A5");

            entity.ToTable("Antiguedad");

            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.IdBanco).HasName("PK__Banco__2D3F553E8999E5D8");

            entity.ToTable("Banco");

            entity.Property(e => e.EsActivo)
                .HasDefaultValue(true)
                .HasColumnName("esActivo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreBanco)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Titular)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Calificacion>(entity =>
        {
            entity.HasKey(e => e.IdCalificacion).HasName("PK__Califica__E056358FFC0043D6");

            entity.ToTable("Calificacion");

            entity.Property(e => e.IdCalificacion).HasColumnName("idCalificacion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Numero).HasColumnName("numero");
        });

        modelBuilder.Entity<Caso>(entity =>
        {
            entity.HasKey(e => e.IdCaso).HasName("PK__Caso__3B7B2BDCDAFE4DEE");

            entity.ToTable("Caso");

            entity.Property(e => e.EsActivo)
                .HasDefaultValue(true)
                .HasColumnName("esActivo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Urgente).HasDefaultValue(true);
        });

        modelBuilder.Entity<CasoAgendada>(entity =>
        {
            entity.HasKey(e => e.IdCasoAgendada).HasName("PK__CasoAgen__E44D48FC1648D584");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.CasoAgendada)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__CasoAgend__IdCas__22401542");

            entity.HasOne(d => d.IdFechaAgendadaNavigation).WithMany(p => p.CasoAgendada)
                .HasForeignKey(d => d.IdFechaAgendada)
                .HasConstraintName("FK__CasoAgend__IdFec__2334397B");
        });

        modelBuilder.Entity<CasoCertificaciones>(entity =>
        {
            entity.HasKey(e => e.IdCasoCertificaciones).HasName("PK__CasoCert__F63B1ED6C078F2A0");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.CasoCertificaciones)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__CasoCerti__IdCas__18B6AB08");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.CasoCertificaciones)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("FK__CasoCerti__IdCer__17C286CF");
        });

        modelBuilder.Entity<CasoEvidencia>(entity =>
        {
            entity.HasKey(e => e.IdCasoEvidencia).HasName("PK__CasoEvid__43B8B3BBC3DEE608");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.CasoEvidencia)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__CasoEvide__IdCas__0D44F85C");

            entity.HasOne(d => d.IdEvidenciaNavigation).WithMany(p => p.CasoEvidencia)
                .HasForeignKey(d => d.IdEvidencia)
                .HasConstraintName("FK__CasoEvide__IdEvi__0C50D423");
        });

        modelBuilder.Entity<CasoFechaSugerida>(entity =>
        {
            entity.HasKey(e => e.IdCasoFechaSugerida).HasName("PK__CasoFech__D2802525C5848285");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.CasoFechaSugerida)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__CasoFecha__IdCas__1B9317B3");

            entity.HasOne(d => d.IdFechaNavigation).WithMany(p => p.CasoFechaSugerida)
                .HasForeignKey(d => d.IdFecha)
                .HasConstraintName("FK__CasoFecha__IdFec__1C873BEC");
        });

        modelBuilder.Entity<CasoHerramienta>(entity =>
        {
            entity.HasKey(e => e.IdCasoHerramientas).HasName("PK__CasoHerr__86B526CCD8E3DB67");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.CasoHerramienta)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__CasoHerra__IdCas__14E61A24");

            entity.HasOne(d => d.IdHerramientaNavigation).WithMany(p => p.CasoHerramienta)
                .HasForeignKey(d => d.IdHerramienta)
                .HasConstraintName("FK__CasoHerra__IdHer__13F1F5EB");
        });

        modelBuilder.Entity<CasoProducto>(entity =>
        {
            entity.HasKey(e => e.IdCasoProducto).HasName("PK__CasoProd__39E87B936F41609A");

            entity.ToTable("CasoProducto");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.CasoProductos)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__CasoProdu__IdCas__11158940");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.CasoProductos)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__CasoProdu__IdPro__10216507");
        });

        modelBuilder.Entity<CasoRiesgo>(entity =>
        {
            entity.HasKey(e => e.IdCasoRiesgo).HasName("PK__CasoRies__AB4B42926264504B");

            entity.ToTable("CasoRiesgo");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.CasoRiesgos)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__CasoRiesg__IdCas__00DF2177");

            entity.HasOne(d => d.IdRiesgoNavigation).WithMany(p => p.CasoRiesgos)
                .HasForeignKey(d => d.IdRiesgo)
                .HasConstraintName("FK__CasoRiesg__IdRie__7FEAFD3E");
        });

        modelBuilder.Entity<CategoriaSubCategoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoriaSubCategoria).HasName("PK__Categori__644B642B9527C2E3");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.CategoriaSubCategoria)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Categoria__IdCat__6166761E");

            entity.HasOne(d => d.IdSubCategoriaNavigation).WithMany(p => p.CategoriaSubCategoria)
                .HasForeignKey(d => d.IdSubCategoria)
                .HasConstraintName("FK__Categoria__IdSub__625A9A57");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__A3C02A10727BEBD4");

            entity.Property(e => e.EsActivo)
                .HasDefaultValue(true)
                .HasColumnName("esActivo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Certificaciones>(entity =>
        {
            entity.HasKey(e => e.IdCertificacion).HasName("PK__Certific__29FBE98D25745CD3");

            entity.Property(e => e.FechaRealizado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaVigencia).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.IdChat).HasName("PK__Chat__8307BCB3FCCD0339");

            entity.ToTable("Chat");

            entity.Property(e => e.IdChat).HasColumnName("idChat");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Numero)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("titulo");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.IdCompany).HasName("PK__Company__3AF752DF9FDA0429");

            entity.ToTable("Company");

            entity.Property(e => e.Celular)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.CodigoCiiu).HasColumnName("CodigoCIIU");
            entity.Property(e => e.Correo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CorreoFacturacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.EsActivo)
                .HasDefaultValue(true)
                .HasColumnName("esActivo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Fijo)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAntiguedadNavigation).WithMany(p => p.Companies)
                .HasForeignKey(d => d.IdAntiguedad)
                .HasConstraintName("FK__Company__IdAntig__208CD6FA");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Companies)
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK__Company__IdPerso__2180FB33");

            entity.HasOne(d => d.IdRegimenNavigation).WithMany(p => p.Companies)
                .HasForeignKey(d => d.IdRegimen)
                .HasConstraintName("FK__Company__IdRegim__22751F6C");

            entity.HasOne(d => d.IdSectorNavigation).WithMany(p => p.Companies)
                .HasForeignKey(d => d.IdSector)
                .HasConstraintName("FK__Company__IdSecto__1F98B2C1");
        });

        modelBuilder.Entity<Cotizacion>(entity =>
        {
            entity.HasKey(e => e.IdCotizacion).HasName("PK__Cotizaci__9A6DA9EF8F7730D1");

            entity.ToTable("Cotizacion");

            entity.Property(e => e.Detalle)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.EsAprobado)
                .HasDefaultValue(true)
                .HasColumnName("esAprobado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.Cotizacions)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__Cotizacio__IdCas__27F8EE98");

            entity.HasOne(d => d.IdTipoPagoNavigation).WithMany(p => p.Cotizacions)
                .HasForeignKey(d => d.IdTipoPago)
                .HasConstraintName("FK__Cotizacio__IdTip__2704CA5F");
        });

        modelBuilder.Entity<CotizacionImpuesto>(entity =>
        {
            entity.HasKey(e => e.IdCotizacionImpuestos).HasName("PK__Cotizaci__B7AD6762A67F032B");

            entity.HasOne(d => d.IdCotizacionNavigation).WithMany(p => p.CotizacionImpuestos)
                .HasForeignKey(d => d.IdCotizacion)
                .HasConstraintName("FK__Cotizacio__IdCot__2BC97F7C");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.CotizacionImpuestos)
                .HasForeignKey(d => d.IdImpuesto)
                .HasConstraintName("FK__Cotizacio__IdImp__2CBDA3B5");
        });

        modelBuilder.Entity<DetalleVenta>(entity =>
        {
            entity.HasKey(e => e.IdDetalleVenta).HasName("PK__DetalleV__AAA5CEC25CB6093D");

            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__DetalleVe__IdCas__382F5661");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("FK__DetalleVe__IdFac__373B3228");
        });

        modelBuilder.Entity<Divisa>(entity =>
        {
            entity.HasKey(e => e.IdDivisa).HasName("PK__Divisa__96114A566560DDB3");

            entity.ToTable("Divisa");

            entity.Property(e => e.IdDivisa).HasColumnName("idDivisa");
            entity.Property(e => e.EsActivo)
                .HasDefaultValue(true)
                .HasColumnName("esActivo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<EncuestaEvidencia>(entity =>
        {
            entity.HasKey(e => e.IdEncuestaEvidencia).HasName("PK__Encuesta__9100CE7E137C5636");

            entity.HasOne(d => d.IdEncuestaNavigation).WithMany(p => p.EncuestaEvidencia)
                .HasForeignKey(d => d.IdEncuesta)
                .HasConstraintName("FK__EncuestaE__IdEnc__0880433F");

            entity.HasOne(d => d.IdEvidenciaNavigation).WithMany(p => p.EncuestaEvidencia)
                .HasForeignKey(d => d.IdEvidencia)
                .HasConstraintName("FK__EncuestaE__IdEvi__09746778");
        });

        modelBuilder.Entity<Encuesta>(entity =>
        {
            entity.HasKey(e => e.IdEncuesta).HasName("PK__Encuesta__72579B544A9A945E");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Encuesta)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Encuesta__IdCate__03BB8E22");

            entity.HasOne(d => d.IdEvidenciaNavigation).WithMany(p => p.Encuesta)
                .HasForeignKey(d => d.IdEvidencia)
                .HasConstraintName("FK__Encuesta__IdEvid__04AFB25B");
        });

        modelBuilder.Entity<Evidencia>(entity =>
        {
            entity.HasKey(e => e.IdEvidencia).HasName("PK__Evidenci__C602EF7E43FD2C0F");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Foto)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TipoArchivo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("url");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__Factura__50E7BAF18684BF14");

            entity.ToTable("Factura");

            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdTipoPagoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdTipoPago)
                .HasConstraintName("FK__Factura__IdTipoP__2F9A1060");
        });

        modelBuilder.Entity<FacturaImpuesto>(entity =>
        {
            entity.HasKey(e => e.IdFacturaImpuestos).HasName("PK__FacturaI__BA8E4D0E2FC29D09");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.FacturaImpuestos)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("FK__FacturaIm__IdFac__336AA144");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.FacturaImpuestos)
                .HasForeignKey(d => d.IdImpuesto)
                .HasConstraintName("FK__FacturaIm__IdImp__345EC57D");
        });

        modelBuilder.Entity<FechaAgendada>(entity =>
        {
            entity.HasKey(e => e.IdFechaAgendada).HasName("PK__FechaAge__009ADBB4AC957995");

            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<FechaSugerida>(entity =>
        {
            entity.HasKey(e => e.IdFecha).HasName("PK__FechaSug__8D0F205A0ADDDAE3");

            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
        });

        modelBuilder.Entity<FileData>(entity =>
        {
            entity.HasKey(e => e.IdFile).HasName("PK__FileData__775AFE720376F67A");

            entity.Property(e => e.IdFile).HasColumnName("idFile");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("extension");
            entity.Property(e => e.IdImagen).HasColumnName("idImagen");
            entity.Property(e => e.MimeType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mimeType");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("path");

            entity.HasOne(d => d.IdImagenNavigation).WithMany(p => p.FileData)
                .HasForeignKey(d => d.IdImagen)
                .HasConstraintName("FK__FileData__idImag__37703C52");
        });

        modelBuilder.Entity<Herramienta>(entity =>
        {
            entity.HasKey(e => e.IdHerramienta).HasName("PK__Herramie__2DAAFAF41646C0E5");

            entity.Property(e => e.Foto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("url");
        });

        modelBuilder.Entity<Imagen>(entity =>
        {
            entity.HasKey(e => e.IdImagen).HasName("PK__Imagen__EA9A713620F5AC89");

            entity.ToTable("Imagen");

            entity.Property(e => e.IdImagen).HasColumnName("idImagen");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Impuesto>(entity =>
        {
            entity.HasKey(e => e.IdImpuesto).HasName("PK__Impuesto__A9B88928901C7D14");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Mensaje>(entity =>
        {
            entity.HasKey(e => e.IdMensaje).HasName("PK__Mensaje__45E42C144D2A1501");

            entity.ToTable("Mensaje");

            entity.Property(e => e.IdMensaje).HasColumnName("idMensaje");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Texto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("texto");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.IdMenu).HasName("PK__Menu__4D7EA8E1AFD07DDF");

            entity.ToTable("Menu");

            entity.Property(e => e.Icono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("url");
        });

        modelBuilder.Entity<MenuRol>(entity =>
        {
            entity.HasKey(e => e.IdMenuRol).HasName("PK__MenuRol__F8D2D5B6E674735B");

            entity.ToTable("MenuRol");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.MenuRols)
                .HasForeignKey(d => d.IdMenu)
                .HasConstraintName("FK__MenuRol__IdMenu__5D95E53A");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.MenuRols)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__MenuRol__IdRol__5E8A0973");
        });

        modelBuilder.Entity<NivelDificultad>(entity =>
        {
            entity.HasKey(e => e.IdNivel).HasName("PK__NivelDif__A7F93DEC39C6E2B9");

            entity.ToTable("NivelDificultad");

            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NumeroDocumento>(entity =>
        {
            entity.HasKey(e => e.IdNumeroDocumento).HasName("PK__NumeroDo__6DFF4A6CD960353E");

            entity.ToTable("NumeroDocumento");

            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UltimoNumero).HasColumnName("Ultimo_Numero");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.NumeroDocumentos)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("FK__NumeroDoc__IdDoc__6754599E");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("PK__Persona__2EC8D2ACCFA7E153");

            entity.ToTable("Persona");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__0988921025467A2B");

            entity.ToTable("Producto");

            entity.Property(e => e.EsProveedor)
                .HasDefaultValue(true)
                .HasColumnName("esProveedor");
            entity.Property(e => e.FechaInventario).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__Producto__IdCaso__3D2915A8");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Producto__IdCate__3C34F16F");

            entity.HasOne(d => d.IdCompanyNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCompany)
                .HasConstraintName("FK__Producto__IdComp__3B40CD36");
        });

        modelBuilder.Entity<Regimen>(entity =>
        {
            entity.HasKey(e => e.IdRegimen).HasName("PK__Regimen__36E253CBD51CB9CE");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Riesgo>(entity =>
        {
            entity.HasKey(e => e.IdRiesgo).HasName("PK__Riesgo__5D6727887429D247");

            entity.ToTable("Riesgo");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEvidenciaNavigation).WithMany(p => p.Riesgos)
                .HasForeignKey(d => d.IdEvidencia)
                .HasConstraintName("FK__Riesgo__IdEviden__690797E6");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Rol__2A49584C9C2EB035");

            entity.ToTable("Rol");

            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Rubro>(entity =>
        {
            entity.HasKey(e => e.IdRubro).HasName("PK__Rubro__5355E1C1A7DD6C0F");

            entity.ToTable("Rubro");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RubroCaso>(entity =>
        {
            entity.HasKey(e => e.IdRubroCaso).HasName("PK__RubroCas__59DB6DB6CF748681");

            entity.ToTable("RubroCaso");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.RubroCasos)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__RubroCaso__IdCas__56E8E7AB");

            entity.HasOne(d => d.IdRubroNavigation).WithMany(p => p.RubroCasos)
                .HasForeignKey(d => d.IdRubro)
                .HasConstraintName("FK__RubroCaso__IdRub__55F4C372");
        });

        modelBuilder.Entity<RubroCompany>(entity =>
        {
            entity.HasKey(e => e.IdRubroCompany).HasName("PK__RubroCom__D53FC615E0DC28AC");

            entity.ToTable("RubroCompany");

            entity.HasOne(d => d.IdCompany7Navigation).WithMany(p => p.RubroCompanies)
                .HasForeignKey(d => d.IdCompany7)
                .HasConstraintName("FK__RubroComp__IdCom__531856C7");

            entity.HasOne(d => d.IdRubroNavigation).WithMany(p => p.RubroCompanies)
                .HasForeignKey(d => d.IdRubro)
                .HasConstraintName("FK__RubroComp__IdRub__5224328E");
        });

        modelBuilder.Entity<RubroProducto>(entity =>
        {
            entity.HasKey(e => e.IdRubroProductos).HasName("PK__RubroPro__76E3854649FCF9F3");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.RubroProductos)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__RubroProd__IdPro__5AB9788F");

            entity.HasOne(d => d.IdRubroNavigation).WithMany(p => p.RubroProductos)
                .HasForeignKey(d => d.IdRubro)
                .HasConstraintName("FK__RubroProd__IdRub__59C55456");
        });

        modelBuilder.Entity<Sector>(entity =>
        {
            entity.HasKey(e => e.IdSector).HasName("PK__Sector__D0011C186847D034");

            entity.ToTable("Sector");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio).HasName("PK__Servicio__2DCCF9A2C58A640C");

            entity.ToTable("Servicio");

            entity.Property(e => e.Acompanamiento).HasDefaultValue(true);
            entity.Property(e => e.EsActivo)
                .HasDefaultValue(true)
                .HasColumnName("esActivo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Supervision).HasDefaultValue(true);
        });

        modelBuilder.Entity<ServicioCaso>(entity =>
        {
            entity.HasKey(e => e.IdServicioCaso).HasName("PK__Servicio__EAF86ADC420CE7D3");

            entity.ToTable("ServicioCaso");

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.ServicioCasos)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__ServicioC__IdCas__719CDDE7");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ServicioCasos)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK__ServicioC__IdSer__70A8B9AE");
        });

        modelBuilder.Entity<ServicioCategorium>(entity =>
        {
            entity.HasKey(e => e.IdServicioCategoria).HasName("PK__Servicio__D957BFA22BD18DEC");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.ServicioCategoria)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__ServicioC__IdCat__6DCC4D03");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ServicioCategoria)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK__ServicioC__IdSer__6CD828CA");
        });

        modelBuilder.Entity<ServicioHerramienta>(entity =>
        {
            entity.HasKey(e => e.IdServicioHerramientas).HasName("PK__Servicio__46ABBBB726B5CB2D");

            entity.HasOne(d => d.IdHerramientaNavigation).WithMany(p => p.ServicioHerramienta)
                .HasForeignKey(d => d.IdHerramienta)
                .HasConstraintName("FK__ServicioH__IdHer__7D0E9093");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ServicioHerramienta)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK__ServicioH__IdSer__7C1A6C5A");
        });

        modelBuilder.Entity<ServicioProducto>(entity =>
        {
            entity.HasKey(e => e.IdServicioProductos).HasName("PK__Servicio__702C6F61EE882B86");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ServicioProductos)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__ServicioP__IdPro__756D6ECB");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ServicioProductos)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK__ServicioP__IdSer__74794A92");
        });

        modelBuilder.Entity<ServicioRiesgo>(entity =>
        {
            entity.HasKey(e => e.IdServicioRiesgo).HasName("PK__Servicio__9F760EE8427E3D90");

            entity.ToTable("ServicioRiesgo");

            entity.HasOne(d => d.IdRiesgoNavigation).WithMany(p => p.ServicioRiesgos)
                .HasForeignKey(d => d.IdRiesgo)
                .HasConstraintName("FK__ServicioR__IdRie__793DFFAF");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ServicioRiesgos)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK__ServicioR__IdSer__7849DB76");
        });

        modelBuilder.Entity<Simulacion>(entity =>
        {
            entity.HasKey(e => e.IdSimulacion).HasName("PK__Simulaci__B550EF96C28E0FF1");

            entity.ToTable("Simulacion");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCasoNavigation).WithMany(p => p.Simulacions)
                .HasForeignKey(d => d.IdCaso)
                .HasConstraintName("FK__Simulacio__IdCas__662B2B3B");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Simulacions)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Simulacio__IdCat__65370702");
        });

        modelBuilder.Entity<Subcategorium>(entity =>
        {
            entity.HasKey(e => e.IdSubCategoria).HasName("PK__Subcateg__0A1EFFE5A5B5D593");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdDocumento).HasName("PK__TipoDocu__E52073470D859C1B");

            entity.ToTable("TipoDocumento");

            entity.Property(e => e.Nombre)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoPago>(entity =>
        {
            entity.HasKey(e => e.IdTipoPago).HasName("PK__TipoPago__EB0AA9E7E6F5108E");

            entity.ToTable("TipoPago");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF97BB697A6C");

            entity.ToTable("Usuario");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Clave)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.EsActivo)
                .HasDefaultValue(true)
                .HasColumnName("esActivo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Usuario__IdCateg__1AD3FDA4");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("FK__Usuario__IdDocum__19DFD96B");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK__Usuario__IdPerso__17F790F9");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Usuario__IdRol__18EBB532");
        });

        modelBuilder.Entity<UsuarioBanco>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioBanco).HasName("PK__UsuarioB__DA9E9844B5454798");

            entity.ToTable("UsuarioBanco");

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.UsuarioBancos)
                .HasForeignKey(d => d.IdBanco)
                .HasConstraintName("FK__UsuarioBa__IdBan__2EDAF651");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioBancos)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__UsuarioBa__IdUsu__2FCF1A8A");
        });

        modelBuilder.Entity<UsuarioCalificacion>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioCalificacion).HasName("PK__UsuarioC__D4AAAA220EC05BD7");

            entity.ToTable("UsuarioCalificacion");

            entity.HasOne(d => d.IdCalificacionNavigation).WithMany(p => p.UsuarioCalificacions)
                .HasForeignKey(d => d.IdCalificacion)
                .HasConstraintName("FK__UsuarioCa__IdCal__2B0A656D");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioCalificacions)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__UsuarioCa__IdUsu__2BFE89A6");
        });

        modelBuilder.Entity<UsuarioCertificaciones>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioCertificacion).HasName("PK__UsuarioC__0992584F0C6E76F5");

            entity.HasOne(d => d.IdCertificacionNavigation).WithMany(p => p.UsuarioCertificaciones)
                .HasForeignKey(d => d.IdCertificacion)
                .HasConstraintName("FK__UsuarioCe__IdCer__4A8310C6");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioCertificaciones)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__UsuarioCe__IdUsu__4B7734FF");
        });

        modelBuilder.Entity<UsuarioChat>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioChat).HasName("PK__UsuarioC__D9C2939CC2CD59C5");

            entity.ToTable("UsuarioChat");

            entity.Property(e => e.IdUsuarioChat).HasColumnName("idUsuarioChat");
            entity.Property(e => e.IdChat).HasColumnName("idChat");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

            entity.HasOne(d => d.IdChatNavigation).WithMany(p => p.UsuarioChats)
                .HasForeignKey(d => d.IdChat)
                .HasConstraintName("FK__UsuarioCh__idCha__44CA3770");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioChats)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__UsuarioCh__idUsu__43D61337");
        });

        modelBuilder.Entity<UsuarioCompany>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioCompany).HasName("PK__UsuarioC__ED714D2958F8A52A");

            entity.ToTable("UsuarioCompany");

            entity.HasOne(d => d.IdCompanyNavigation).WithMany(p => p.UsuarioCompanies)
                .HasForeignKey(d => d.IdCompany)
                .HasConstraintName("FK__UsuarioCo__IdCom__4F47C5E3");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioCompanies)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__UsuarioCo__IdUsu__4E53A1AA");
        });

        modelBuilder.Entity<UsuarioNivel>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioNivel).HasName("PK__UsuarioN__88CCD2BAEC38079A");

            entity.ToTable("UsuarioNivel");

            entity.HasOne(d => d.IdNivelNavigation).WithMany(p => p.UsuarioNivels)
                .HasForeignKey(d => d.IdNivel)
                .HasConstraintName("FK__UsuarioNi__IdNiv__2739D489");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioNivels)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__UsuarioNi__IdUsu__282DF8C2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
