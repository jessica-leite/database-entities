﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Source.Models.Mapping
{
    public class SubmissionMapping : IEntityTypeConfiguration<Submission>
    {
        public void Configure(EntityTypeBuilder<Submission> builder)
        {
            builder.ToTable(nameof(Submission).ToLower());

            builder.HasKey(s => new { s.UserId, s.ChallengeId });

            builder.Property(s => s.Score)
                .IsRequired();

            builder.Property(s => s.CreatedAt)
                .IsRequired();

            builder.HasOne(s => s.User)
                .WithMany(u => u.Submissions);

            builder.HasOne(s => s.Challenge)
                .WithMany(c => c.Submissions);
        }
    }
}
