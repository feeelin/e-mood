﻿/*namespace e_mood_asp_net_core
{
    public class Model
    {
    }
}*/
using e_mood_asp_net_core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class MusicContext : DbContext
{
    public DbSet<Group> Groups { get; set; }
    public DbSet<PlayList> PlayLists { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<User> Users { get; set; }


   /* public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }*/

    public string DbPath { get; }

    public MusicContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "music.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}


/*public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    public List<Post> Posts { get; } = new();
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}*/
