﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieProject.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MovieUser")]
	public partial class MovieUserDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPengguna(Pengguna instance);
    partial void UpdatePengguna(Pengguna instance);
    partial void DeletePengguna(Pengguna instance);
    partial void InsertMovie(Movie instance);
    partial void UpdateMovie(Movie instance);
    partial void DeleteMovie(Movie instance);
    partial void InsertGenre(Genre instance);
    partial void UpdateGenre(Genre instance);
    partial void DeleteGenre(Genre instance);
    partial void InsertCollection(Collection instance);
    partial void UpdateCollection(Collection instance);
    partial void DeleteCollection(Collection instance);
    #endregion
		
		public MovieUserDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MovieUserConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MovieUserDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieUserDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieUserDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieUserDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Pengguna> Penggunas
		{
			get
			{
				return this.GetTable<Pengguna>();
			}
		}
		
		public System.Data.Linq.Table<Movie> Movies
		{
			get
			{
				return this.GetTable<Movie>();
			}
		}
		
		public System.Data.Linq.Table<Genre> Genres
		{
			get
			{
				return this.GetTable<Genre>();
			}
		}
		
		public System.Data.Linq.Table<Collection> Collections
		{
			get
			{
				return this.GetTable<Collection>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pengguna")]
	public partial class Pengguna : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserName;
		
		private string _FullName;
		
		private string _Password;
		
		private System.DateTime _CreatedOn;
		
		private EntitySet<Collection> _Collections;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnCreatedOnChanging(System.DateTime value);
    partial void OnCreatedOnChanged();
    #endregion
		
		public Pengguna()
		{
			this._Collections = new EntitySet<Collection>(new Action<Collection>(this.attach_Collections), new Action<Collection>(this.detach_Collections));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pengguna_Collection", Storage="_Collections", ThisKey="UserName", OtherKey="UserName")]
		public EntitySet<Collection> Collections
		{
			get
			{
				return this._Collections;
			}
			set
			{
				this._Collections.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Collections(Collection entity)
		{
			this.SendPropertyChanging();
			entity.Pengguna = this;
		}
		
		private void detach_Collections(Collection entity)
		{
			this.SendPropertyChanging();
			entity.Pengguna = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Movie")]
	public partial class Movie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MovieID;
		
		private string _MovieName;
		
		private System.DateTime _ReleaseYear;
		
		private int _GenreID;
		
		private EntitySet<Collection> _Collections;
		
		private EntityRef<Genre> _Genre;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMovieIDChanging(int value);
    partial void OnMovieIDChanged();
    partial void OnMovieNameChanging(string value);
    partial void OnMovieNameChanged();
    partial void OnReleaseYearChanging(System.DateTime value);
    partial void OnReleaseYearChanged();
    partial void OnGenreIDChanging(int value);
    partial void OnGenreIDChanged();
    #endregion
		
		public Movie()
		{
			this._Collections = new EntitySet<Collection>(new Action<Collection>(this.attach_Collections), new Action<Collection>(this.detach_Collections));
			this._Genre = default(EntityRef<Genre>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MovieID
		{
			get
			{
				return this._MovieID;
			}
			set
			{
				if ((this._MovieID != value))
				{
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._MovieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MovieName
		{
			get
			{
				return this._MovieName;
			}
			set
			{
				if ((this._MovieName != value))
				{
					this.OnMovieNameChanging(value);
					this.SendPropertyChanging();
					this._MovieName = value;
					this.SendPropertyChanged("MovieName");
					this.OnMovieNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReleaseYear", DbType="Date NOT NULL")]
		public System.DateTime ReleaseYear
		{
			get
			{
				return this._ReleaseYear;
			}
			set
			{
				if ((this._ReleaseYear != value))
				{
					this.OnReleaseYearChanging(value);
					this.SendPropertyChanging();
					this._ReleaseYear = value;
					this.SendPropertyChanged("ReleaseYear");
					this.OnReleaseYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GenreID", DbType="Int NOT NULL")]
		public int GenreID
		{
			get
			{
				return this._GenreID;
			}
			set
			{
				if ((this._GenreID != value))
				{
					if (this._Genre.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGenreIDChanging(value);
					this.SendPropertyChanging();
					this._GenreID = value;
					this.SendPropertyChanged("GenreID");
					this.OnGenreIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_Collection", Storage="_Collections", ThisKey="MovieID", OtherKey="MovieID")]
		public EntitySet<Collection> Collections
		{
			get
			{
				return this._Collections;
			}
			set
			{
				this._Collections.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Genre_Movie", Storage="_Genre", ThisKey="GenreID", OtherKey="GenreID", IsForeignKey=true)]
		public Genre Genre
		{
			get
			{
				return this._Genre.Entity;
			}
			set
			{
				Genre previousValue = this._Genre.Entity;
				if (((previousValue != value) 
							|| (this._Genre.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Genre.Entity = null;
						previousValue.Movies.Remove(this);
					}
					this._Genre.Entity = value;
					if ((value != null))
					{
						value.Movies.Add(this);
						this._GenreID = value.GenreID;
					}
					else
					{
						this._GenreID = default(int);
					}
					this.SendPropertyChanged("Genre");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Collections(Collection entity)
		{
			this.SendPropertyChanging();
			entity.Movie = this;
		}
		
		private void detach_Collections(Collection entity)
		{
			this.SendPropertyChanging();
			entity.Movie = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Genre")]
	public partial class Genre : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _GenreID;
		
		private string _GenreName;
		
		private EntitySet<Movie> _Movies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGenreIDChanging(int value);
    partial void OnGenreIDChanged();
    partial void OnGenreNameChanging(string value);
    partial void OnGenreNameChanged();
    #endregion
		
		public Genre()
		{
			this._Movies = new EntitySet<Movie>(new Action<Movie>(this.attach_Movies), new Action<Movie>(this.detach_Movies));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GenreID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int GenreID
		{
			get
			{
				return this._GenreID;
			}
			set
			{
				if ((this._GenreID != value))
				{
					this.OnGenreIDChanging(value);
					this.SendPropertyChanging();
					this._GenreID = value;
					this.SendPropertyChanged("GenreID");
					this.OnGenreIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GenreName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string GenreName
		{
			get
			{
				return this._GenreName;
			}
			set
			{
				if ((this._GenreName != value))
				{
					this.OnGenreNameChanging(value);
					this.SendPropertyChanging();
					this._GenreName = value;
					this.SendPropertyChanged("GenreName");
					this.OnGenreNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Genre_Movie", Storage="_Movies", ThisKey="GenreID", OtherKey="GenreID")]
		public EntitySet<Movie> Movies
		{
			get
			{
				return this._Movies;
			}
			set
			{
				this._Movies.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Movies(Movie entity)
		{
			this.SendPropertyChanging();
			entity.Genre = this;
		}
		
		private void detach_Movies(Movie entity)
		{
			this.SendPropertyChanging();
			entity.Genre = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Collection")]
	public partial class Collection : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CollectionID;
		
		private int _MovieID;
		
		private string _UserName;
		
		private System.DateTime _CreatedOnCollection;
		
		private EntityRef<Movie> _Movie;
		
		private EntityRef<Pengguna> _Pengguna;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCollectionIDChanging(int value);
    partial void OnCollectionIDChanged();
    partial void OnMovieIDChanging(int value);
    partial void OnMovieIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnCreatedOnCollectionChanging(System.DateTime value);
    partial void OnCreatedOnCollectionChanged();
    #endregion
		
		public Collection()
		{
			this._Movie = default(EntityRef<Movie>);
			this._Pengguna = default(EntityRef<Pengguna>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CollectionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CollectionID
		{
			get
			{
				return this._CollectionID;
			}
			set
			{
				if ((this._CollectionID != value))
				{
					this.OnCollectionIDChanging(value);
					this.SendPropertyChanging();
					this._CollectionID = value;
					this.SendPropertyChanged("CollectionID");
					this.OnCollectionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieID", DbType="Int NOT NULL")]
		public int MovieID
		{
			get
			{
				return this._MovieID;
			}
			set
			{
				if ((this._MovieID != value))
				{
					if (this._Movie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._MovieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					if (this._Pengguna.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOnCollection", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedOnCollection
		{
			get
			{
				return this._CreatedOnCollection;
			}
			set
			{
				if ((this._CreatedOnCollection != value))
				{
					this.OnCreatedOnCollectionChanging(value);
					this.SendPropertyChanging();
					this._CreatedOnCollection = value;
					this.SendPropertyChanged("CreatedOnCollection");
					this.OnCreatedOnCollectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_Collection", Storage="_Movie", ThisKey="MovieID", OtherKey="MovieID", IsForeignKey=true)]
		public Movie Movie
		{
			get
			{
				return this._Movie.Entity;
			}
			set
			{
				Movie previousValue = this._Movie.Entity;
				if (((previousValue != value) 
							|| (this._Movie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movie.Entity = null;
						previousValue.Collections.Remove(this);
					}
					this._Movie.Entity = value;
					if ((value != null))
					{
						value.Collections.Add(this);
						this._MovieID = value.MovieID;
					}
					else
					{
						this._MovieID = default(int);
					}
					this.SendPropertyChanged("Movie");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pengguna_Collection", Storage="_Pengguna", ThisKey="UserName", OtherKey="UserName", IsForeignKey=true)]
		public Pengguna Pengguna
		{
			get
			{
				return this._Pengguna.Entity;
			}
			set
			{
				Pengguna previousValue = this._Pengguna.Entity;
				if (((previousValue != value) 
							|| (this._Pengguna.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Pengguna.Entity = null;
						previousValue.Collections.Remove(this);
					}
					this._Pengguna.Entity = value;
					if ((value != null))
					{
						value.Collections.Add(this);
						this._UserName = value.UserName;
					}
					else
					{
						this._UserName = default(string);
					}
					this.SendPropertyChanged("Pengguna");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
