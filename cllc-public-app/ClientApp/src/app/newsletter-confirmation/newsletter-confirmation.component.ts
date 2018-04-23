import { Component, Input } from '@angular/core';
import { NewsletterDataService } from "../services/newsletter-data.service"
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    selector: 'app-newsletter-confirmation',
    templateUrl: './newsletter-confirmation.component.html',
    styleUrls: ['./newsletter-confirmation.component.scss']
})
/** newsletter-confirmation component*/
export class NewsletterConfirmationComponent {
  @Input('slug') slug: string;

  public description: string;
  public title: string;
  public email: string;
  public code: string;
  public validEmail: any;

    /** newsletter-confirmation ctor */
  constructor(private newsletterDataService: NewsletterDataService, private route: ActivatedRoute,
    private router: Router) {

    this.route.queryParams.subscribe(params => {
      this.code = params['code'];
    });
  }
  
  ngOnInit(): void {

    if (this.slug != null) {
      
      // validate the code.
      this.newsletterDataService.verifyCode(this.slug, this.code)
        .then((verificationResult) => {
          alert(verificationResult); 
        });

      this.newsletterDataService.getNewsletter(this.slug)
        .then((newsletter) => {
          this.description = newsletter.description;
          this.title = newsletter.title;
        });
    }    
  }
}