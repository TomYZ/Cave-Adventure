#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t4012695102;
// UnityEngine.Transform
struct Transform_t284553113;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CameraFollow
struct  CameraFollow_t3148844886  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.GameObject CameraFollow::target
	GameObject_t4012695102 * ___target_2;
	// UnityEngine.Transform CameraFollow::_t
	Transform_t284553113 * ____t_3;

public:
	inline static int32_t get_offset_of_target_2() { return static_cast<int32_t>(offsetof(CameraFollow_t3148844886, ___target_2)); }
	inline GameObject_t4012695102 * get_target_2() const { return ___target_2; }
	inline GameObject_t4012695102 ** get_address_of_target_2() { return &___target_2; }
	inline void set_target_2(GameObject_t4012695102 * value)
	{
		___target_2 = value;
		Il2CppCodeGenWriteBarrier(&___target_2, value);
	}

	inline static int32_t get_offset_of__t_3() { return static_cast<int32_t>(offsetof(CameraFollow_t3148844886, ____t_3)); }
	inline Transform_t284553113 * get__t_3() const { return ____t_3; }
	inline Transform_t284553113 ** get_address_of__t_3() { return &____t_3; }
	inline void set__t_3(Transform_t284553113 * value)
	{
		____t_3 = value;
		Il2CppCodeGenWriteBarrier(&____t_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
