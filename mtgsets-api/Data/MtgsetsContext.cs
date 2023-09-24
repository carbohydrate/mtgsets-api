using Microsoft.EntityFrameworkCore;
using Mtgsets.Models.Generated;

namespace Mtgsets.Data;

public partial class MtgsetsContext : DbContext
{
    public MtgsetsContext()
    {
    }

    public MtgsetsContext(DbContextOptions<MtgsetsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Card> Cards { get; set; }
    public virtual DbSet<CardForeignData> CardForeignData { get; set; }
    public virtual DbSet<CardIdentifier> CardIdentifiers { get; set; }
    public virtual DbSet<CardLegality> CardLegalities { get; set; }
    public virtual DbSet<CardPurchaseUrl> CardPurchaseUrls { get; set; }
    public virtual DbSet<CardRuling> CardRulings { get; set; }
    public virtual DbSet<Meta> Meta { get; set; }
    public virtual DbSet<Set> Sets { get; set; }
    public virtual DbSet<SetBoosterContent> SetBoosterContents { get; set; }
    public virtual DbSet<SetBoosterContentWeight> SetBoosterContentWeights { get; set; }
    public virtual DbSet<SetBoosterSheet> SetBoosterSheets { get; set; }
    public virtual DbSet<SetBoosterSheetCard> SetBoosterSheetCards { get; set; }
    public virtual DbSet<SetTranslation> SetTranslations { get; set; }
    public virtual DbSet<Token> Tokens { get; set; }
    public virtual DbSet<TokenIdentifier> TokenIdentifiers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Card>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cards_pkey");
        });

        modelBuilder.Entity<CardForeignData>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cardforeigndata_pkey");
        });

        modelBuilder.Entity<CardIdentifier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cardidentifiers_pkey");
        });

        modelBuilder.Entity<CardLegality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cardlegalities_pkey");
        });

        modelBuilder.Entity<CardPurchaseUrl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cardpurchaseurls_pkey");
        });

        modelBuilder.Entity<CardRuling>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cardrulings_pkey");
        });

        modelBuilder.Entity<Meta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("meta_pkey");
        });

        modelBuilder.Entity<Set>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sets_pkey");
        });

        modelBuilder.Entity<SetBoosterContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("setboostercontents_pkey");
        });

        modelBuilder.Entity<SetBoosterContentWeight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("setboostercontentweights_pkey");
        });

        modelBuilder.Entity<SetBoosterSheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("setboostersheets_pkey");
        });

        modelBuilder.Entity<SetBoosterSheetCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("setboostersheetcards_pkey");
        });

        modelBuilder.Entity<SetTranslation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("settranslations_pkey");
        });

        modelBuilder.Entity<Token>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tokens_pkey");
        });

        modelBuilder.Entity<TokenIdentifier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tokenidentifiers_pkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
