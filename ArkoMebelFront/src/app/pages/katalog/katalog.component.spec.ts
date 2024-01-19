import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KatalogComponent } from './katalog.component';

describe('KatalogComponent', () => {
  let component: KatalogComponent;
  let fixture: ComponentFixture<KatalogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [KatalogComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(KatalogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
