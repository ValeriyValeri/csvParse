import { Component } from '@angular/core';
import { RequestOptions } from '@angular/http';
import { HttpClient, HttpParams } from '@angular/common/http';
import { UploadService } from '../services/upload.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  providers: [UploadService]
})
export class HomeComponent {

  constructor(private uploadService: UploadService) {}

  enableHeaders: boolean = false;
  text: string;
  items:JSON;
  tempItems:JSON;
  isUploaded:boolean=false;
  isUpl:boolean=false;



  Upload(event) {
    if(event.target.files.length>0)
    {
     let fileList: FileList = event.target.files;
    this.uploadService.Upload(fileList).subscribe(
      (data:JSON)=>{        
        console.log(data);   
        this.tempItems=data;   
           
    },
    (error:Error)=>
    {
      console.log(error.message);
   });
  }
  }

  View() {
    if(this.tempItems!=null)
    {
    this.isUploaded=true;
    this.items=this.tempItems;
    }
    else
    {
      this.isUploaded=false;
    }
  }

  Sort(event)
  {
    console.log(event.target.id);
  }
}
