import { Component, OnInit } from '@angular/core';
import { MatPaginator, MatTableDataSource, MatSort, MatDialog, MatDialogConfig, MatDialogRef } from '@angular/material';
import { Shareholder } from '../models/shareholder.model';
import { FormBuilder, FormGroup, FormControl, Validators, NgForm } from '@angular/forms';
import { AdoxioLegalEntityDataService } from "../services/adoxio-legal-entity-data.service";

@Component({
  selector: 'app-edit-shareholders',
  templateUrl: './edit-shareholders.component.html',
  styleUrls: ['./edit-shareholders.component.scss']
})

export class EditShareholdersComponent implements OnInit {

  shareholderForm: FormGroup;
  shareholderList: Shareholder[] = [];
  dataSource = new MatTableDataSource<Shareholder>();
  public dataLoaded;
  displayedColumns = ['shareholderType', 'name', 'email', 'numberOfNonVotingShares', 'numberOfVotingShares', 'dateIssued'];

  constructor(private frmbuilder: FormBuilder, private legalEntityDataservice: AdoxioLegalEntityDataService,
              public dialog: MatDialog)
  {
    this.shareholderForm = frmbuilder.group({
      shareholderType: new FormControl(),
      firstName: new FormControl(),
      lastName: new FormControl(),
      email: new FormControl(),
      numberOfNonVotingShares: new FormControl(),
      numberOfVotingShares: new FormControl(),
      dateIssued: new FormControl()
    });
  }

  ngOnInit() {

    let shareholder: Shareholder;
    //shareholder = this.getShareholderTest();
    //this.shareholderList.push(shareholder);

    this.dataSource.data = this.shareholderList;
    this.dataLoaded = true;
  }

  addShareholderPerson(shareholderForm: NgForm) {
    console.log(shareholderForm.controls);
    let shareholderModel = this.toShareholderModel(shareholderForm, "Person");
    console.log(shareholderModel);
    this.legalEntityDataservice.post(shareholderModel);
    this.addShareholdertoTable(shareholderForm);
    this.dataSource.data = this.shareholderList;
  }

  toShareholderModel(shareholderForm: NgForm, shareholderType: string ): Shareholder {
    let shareholder: Shareholder = new Shareholder();
    shareholder.id = this.guid();
    if (shareholder.shareholderType = 'Person') {
      shareholder.isindividual = true;
    } else {
      shareholder.shareholderType = 'Organization'
      shareholder.isindividual = false;
    }
    shareholder.firstname = shareholderForm.controls.firstName.value;
    shareholder.lastname = shareholderForm.controls.lastName.value;
    //shareholder.email = shareholderForm.controls.email.value;
    shareholder.commonnonvotingshares = shareholderForm.controls.numberOfNonVotingShares.value;
    shareholder.commonvotingshares = shareholderForm.controls.numberOfVotingShares.value;
    //shareholder.dateIssued = shareholderForm.controls.dateIssued.value;
    shareholder.legalentitytype = "845280001";
    return shareholder;
  }

  addShareholdertoTable(shareholderForm: NgForm) {
    let shareholder: Shareholder;
    shareholder = new Shareholder();
    shareholder.shareholderType = 'Person';
    shareholder.firstname = shareholderForm.controls.firstName.value;
    shareholder.lastname = shareholderForm.controls.lastName.value;
    //shareholder.email = shareholderForm.controls.email.value;
    shareholder.commonnonvotingshares = shareholderForm.controls.numberOfNonVotingShares.value;
    shareholder.commonvotingshares = shareholderForm.controls.numberOfVotingShares.value;
    //shareholder.dateIssued = shareholderForm.controls.dateIssued.value;
    this.shareholderList.push(shareholder);
  }

  getShareholderTest(): Shareholder {
    let shareholder: Shareholder;
    shareholder = new Shareholder();
    shareholder.shareholderType = 'Person';
    shareholder.firstname = 'Test';
    shareholder.lastname = 'Test';
    //shareholder.email = 'Test';
    shareholder.commonnonvotingshares = 0;
    shareholder.commonvotingshares = 0;
    //shareholder.dateIssued = new Date();
    return shareholder;
  }

  guid() {
    return this.s4() + this.s4() + '-' + this.s4() + '-' + this.s4() + '-' +
      this.s4() + '-' + this.s4() + this.s4() + this.s4();
  }

  s4() {
  return Math.floor((1 + Math.random()) * 0x10000)
    .toString(16).substring(1);
  }

  // Person shareholder dialog
  openPersonDialog() {
    const dialogConfig = new MatDialogConfig();

    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;

    dialogConfig.data = {
      id: 1,
      title: 'Angular For Beginners'
    };

    this.dialog.open(ShareholderPersonDialog, dialogConfig);
  }

  // Organization shareholder dialog
  openOrganizationDialog() {
    //const dialogRef = this.dialog.open(ShareholderOrganizationDialog, {
    //  height: '350px'
    //});

    //dialogRef.afterClosed().subscribe(result => {
    //  console.log(`Dialog result: ${result}`);
    //});

    const dialogConfig = new MatDialogConfig();

    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;

    dialogConfig.data = {
      id: 1,
      title: 'Angular For Beginners'
    };

    this.dialog.open(ShareholderOrganizationDialog, dialogConfig);
  }

}

@Component({
  selector: 'edit-shareholders-person-dialog',
  templateUrl: 'edit-shareholders-person-dialog.html',
})
export class ShareholderPersonDialog {
  shareholderForm: FormGroup;

  constructor(private frmbuilder: FormBuilder, private legalEntityDataservice: AdoxioLegalEntityDataService,
    private dialogRef: MatDialogRef<ShareholderPersonDialog>) {
    this.shareholderForm = frmbuilder.group({
      shareholderType: new FormControl(),
      firstName: new FormControl(),
      lastName: new FormControl(),
      email: new FormControl(),
      numberOfNonVotingShares: new FormControl(),
      numberOfVotingShares: new FormControl(),
      dateIssued: new FormControl()
    });
  }

  save() {
    console.log(this.shareholderForm.value);
    this.dialogRef.close(this.shareholderForm.value);
  }

  close() {
    this.dialogRef.close();
  }

}

@Component({
  selector: 'edit-shareholders-organization-dialog',
  templateUrl: 'edit-shareholders-organization-dialog.html',
})
export class ShareholderOrganizationDialog { }