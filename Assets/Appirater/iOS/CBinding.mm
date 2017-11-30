//
//  CBinding.m
//  rateus test
//
//  Created by nicloay on 29/11/2017.
//  Copyright © 2017 nicloay.com. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "CBinding.h"
#import "Appirater.h"

extern "C" {
        
    void _Init(const char* appId,
               const int daysUntilPrompt,
               const int usesUntilPrompt,
               const int significantEventsUntilPrompt,
               const int timeBeforeReminding,
               const bool debug){
        [Appirater setAppId:[NSString stringWithUTF8String:appId]];
        [Appirater setDaysUntilPrompt:daysUntilPrompt];
        [Appirater setUsesUntilPrompt:usesUntilPrompt];
        [Appirater setSignificantEventsUntilPrompt:significantEventsUntilPrompt];
        [Appirater setTimeBeforeReminding:timeBeforeReminding];
        [Appirater setDebug:debug];
        [Appirater appLaunched:YES];
    }
    
    void _DidSignificantEvent(){
        [Appirater userDidSignificantEvent:YES];
    }
    
    void _AppGoesToBackground(const bool bg){
        [Appirater appEnteredForeground:bg];
    }    
}
