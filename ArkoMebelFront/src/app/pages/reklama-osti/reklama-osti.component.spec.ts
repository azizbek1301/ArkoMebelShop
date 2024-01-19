import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReklamaOstiComponent } from './reklama-osti.component';

describe('ReklamaOstiComponent', () => {
  let component: ReklamaOstiComponent;
  let fixture: ComponentFixture<ReklamaOstiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ReklamaOstiComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ReklamaOstiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
