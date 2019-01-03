import { RequestOptions } from '@angular/http';
import { HttpClient, HttpRequest, HttpEventType, HttpResponse} from '@angular/common/http';
import { Injectable } from '@angular/core';
import{Observable} from 'rxjs'
import { map } from 'rxjs/operators';
import { Http } from '@angular/http';


@Injectable()
export class UploadService {
 
    constructor(private http:HttpClient)
    {

    }

    Upload(fileList: FileList){

        
        if(fileList.length > 0) {
            let file: File = fileList[0];
            let formData:FormData = new FormData();
        
            formData.append(file.name, file);
       //     let headers = new Headers();
                              
            //const req = new HttpRequest('POST', `CSV/Create`, formData);                                        
             return this.http.post('CSV/Create', formData);                
       }
    }
}