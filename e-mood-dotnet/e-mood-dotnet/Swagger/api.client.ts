//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

/* tslint:disable */
/* eslint-disable */
// ReSharper disable InconsistentNaming



export class Playlist implements IPlaylist {
    id?: string;
    name?: string | undefined;
    description?: string | undefined;
    ownerId?: string;
    subscribers?: User[] | undefined;
    coverUrl?: string | undefined;

    constructor(data?: IPlaylist) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.id = _data["id"];
            this.name = _data["name"];
            this.description = _data["description"];
            this.ownerId = _data["ownerId"];
            if (Array.isArray(_data["subscribers"])) {
                this.subscribers = [] as any;
                for (let item of _data["subscribers"])
                    this.subscribers!.push(User.fromJS(item));
            }
            this.coverUrl = _data["coverUrl"];
        }
    }

    static fromJS(data: any): Playlist {
        data = typeof data === 'object' ? data : {};
        let result = new Playlist();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["name"] = this.name;
        data["description"] = this.description;
        data["ownerId"] = this.ownerId;
        if (Array.isArray(this.subscribers)) {
            data["subscribers"] = [];
            for (let item of this.subscribers)
                data["subscribers"].push(item.toJSON());
        }
        data["coverUrl"] = this.coverUrl;
        return data;
    }
}

export interface IPlaylist {
    id?: string;
    name?: string | undefined;
    description?: string | undefined;
    ownerId?: string;
    subscribers?: User[] | undefined;
    coverUrl?: string | undefined;
}

export class Track implements ITrack {
    id?: string;
    title?: string | undefined;
    artist?: string | undefined;
    url?: string | undefined;
    duration?: string;
    playlist?: Playlist;

    constructor(data?: ITrack) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.id = _data["id"];
            this.title = _data["title"];
            this.artist = _data["artist"];
            this.url = _data["url"];
            this.duration = _data["duration"];
            this.playlist = _data["playlist"] ? Playlist.fromJS(_data["playlist"]) : <any>undefined;
        }
    }

    static fromJS(data: any): Track {
        data = typeof data === 'object' ? data : {};
        let result = new Track();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["title"] = this.title;
        data["artist"] = this.artist;
        data["url"] = this.url;
        data["duration"] = this.duration;
        data["playlist"] = this.playlist ? this.playlist.toJSON() : <any>undefined;
        return data;
    }
}

export interface ITrack {
    id?: string;
    title?: string | undefined;
    artist?: string | undefined;
    url?: string | undefined;
    duration?: string;
    playlist?: Playlist;
}

export class User implements IUser {
    id?: string;
    name?: string | undefined;
    surname?: string | undefined;
    pictureUrl?: string | undefined;

    constructor(data?: IUser) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.id = _data["id"];
            this.name = _data["name"];
            this.surname = _data["surname"];
            this.pictureUrl = _data["pictureUrl"];
        }
    }

    static fromJS(data: any): User {
        data = typeof data === 'object' ? data : {};
        let result = new User();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["name"] = this.name;
        data["surname"] = this.surname;
        data["pictureUrl"] = this.pictureUrl;
        return data;
    }
}

export interface IUser {
    id?: string;
    name?: string | undefined;
    surname?: string | undefined;
    pictureUrl?: string | undefined;
}